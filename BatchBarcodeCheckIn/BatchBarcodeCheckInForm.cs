using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace BatchBarcodeCheckIn
{
    public partial class BatchBarcodeCheckInForm : Form
    {
        private string _librarySystemProcessName;
        private int _loopDelayTime;
        private Process _librarySystemProcess;
        private string _shortKeyForCheckInWindows;

        public BatchBarcodeCheckInForm()
        {
            InitializeComponent();

            var setting = Properties.Settings.Default;
            _librarySystemProcessName = setting.LibrarySystemProcessName;
            _loopDelayTime = Convert.ToInt32(setting.LoopDelayTime);
            _shortKeyForCheckInWindows = setting.ShortKeyForCheckInWindows;
        }

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private Process GetLibrarySystemProcess(string processName = null)
        {
            if (processName == null)
            {
                processName = _librarySystemProcessName;
            }

            try
            {
                _librarySystemProcess = Process.GetProcessesByName(processName)[0];
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                return null;
            }

            return _librarySystemProcess;
        }

        private void browse_file_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            var filename = openFile.FileName;
            txt_filename.Text = filename;
        }

        private void btn_sendbarcode_Click(object sender, EventArgs e)
        {
            if (textBox.Text == string.Empty)
            {
                MessageBox.Show(@"กรุณากรอกบาร์โคด");
                return;
            }

            var barcodeStr = textBox.Text;

            var libSysProcess = GetLibrarySystemProcess();

            if (libSysProcess != null)
            {
                SendCheckInBarCode(barcodeStr, libSysProcess);
                MessageBox.Show(@"Send Barcode Completed");
            }
            else
            {
                MessageBox.Show(@"Cannot find library system process name : " + _librarySystemProcessName, @"Error!");
            }


        }

        private void checkin_all_btn_Click(object sender, EventArgs e)
        {
            if (txt_filename.Text == string.Empty)
            {
                MessageBox.Show(@"ยังไม่ได้เลือกไฟล์");
                return;
            }

            var file = new StreamReader(txt_filename.Text);

            string currentBarcode;
            var libSysProcess = GetLibrarySystemProcess();

            if (libSysProcess == null)
            {
                MessageBox.Show(@"Cannot find library system process name : " + _librarySystemProcessName, @"Error!");
                return;
            }

            while ((currentBarcode = file.ReadLine()) != null)
            {
                //Console.WriteLine( @"Check In : " + currentBarcode + Environment.NewLine);
                SendCheckInBarCode(currentBarcode, libSysProcess);
            }
        }

        private void SendCheckInBarCode(string barcode, Process libSysProcess)
        {

            SetForegroundWindow(libSysProcess.MainWindowHandle);

            if (_shortKeyForCheckInWindows != null)
            {
                libSysProcess.WaitForInputIdle();
                SendKeys.Send(_shortKeyForCheckInWindows);
            }

            libSysProcess.WaitForInputIdle();
            SendKeys.Send(barcode);
            SendKeys.Send("{ENTER}");
            
            Thread.Sleep(_loopDelayTime);
            // Resend Enter key for closing some error dialog box on Library Software
            libSysProcess.WaitForInputIdle();
            SendKeys.Send("{ENTER}");

            //Console.WriteLine(@"Send Barcode : " + barcode);
        }


        private void result_txt_TextChanged(object sender, EventArgs e)
        {
            result_txt.SelectionStart = result_txt.Text.Length;
            result_txt.ScrollToCaret();
        }
    }
}