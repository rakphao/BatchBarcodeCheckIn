namespace BatchBarcodeCheckIn
{
    partial class BatchBarcodeCheckInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.btn_sendbarcode = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.browse_file = new System.Windows.Forms.Button();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.checkin_all_btn = new System.Windows.Forms.Button();
            this.result_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(33, 154);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(339, 20);
            this.textBox.TabIndex = 1;
            // 
            // btn_sendbarcode
            // 
            this.btn_sendbarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sendbarcode.Location = new System.Drawing.Point(378, 154);
            this.btn_sendbarcode.Name = "btn_sendbarcode";
            this.btn_sendbarcode.Size = new System.Drawing.Size(114, 23);
            this.btn_sendbarcode.TabIndex = 6;
            this.btn_sendbarcode.Text = "send barcode";
            this.btn_sendbarcode.UseVisualStyleBackColor = true;
            this.btn_sendbarcode.Click += new System.EventHandler(this.btn_sendbarcode_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // browse_file
            // 
            this.browse_file.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browse_file.Location = new System.Drawing.Point(258, 115);
            this.browse_file.Name = "browse_file";
            this.browse_file.Size = new System.Drawing.Size(114, 23);
            this.browse_file.TabIndex = 7;
            this.browse_file.Text = "Browse File";
            this.browse_file.UseVisualStyleBackColor = true;
            this.browse_file.Click += new System.EventHandler(this.browse_file_Click);
            // 
            // txt_filename
            // 
            this.txt_filename.Location = new System.Drawing.Point(33, 115);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.ReadOnly = true;
            this.txt_filename.Size = new System.Drawing.Size(219, 20);
            this.txt_filename.TabIndex = 8;
            // 
            // checkin_all_btn
            // 
            this.checkin_all_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkin_all_btn.Location = new System.Drawing.Point(378, 115);
            this.checkin_all_btn.Name = "checkin_all_btn";
            this.checkin_all_btn.Size = new System.Drawing.Size(114, 23);
            this.checkin_all_btn.TabIndex = 9;
            this.checkin_all_btn.Text = "Check IN All";
            this.checkin_all_btn.UseVisualStyleBackColor = true;
            this.checkin_all_btn.Click += new System.EventHandler(this.checkin_all_btn_Click);
            // 
            // result_txt
            // 
            this.result_txt.Location = new System.Drawing.Point(33, 183);
            this.result_txt.Multiline = true;
            this.result_txt.Name = "result_txt";
            this.result_txt.ReadOnly = true;
            this.result_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.result_txt.Size = new System.Drawing.Size(459, 330);
            this.result_txt.TabIndex = 10;
            this.result_txt.TextChanged += new System.EventHandler(this.result_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "โปรแกรม Barcode Batch Check In ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(459, 43);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "ต้องทำการเปิดโปรแกรม Virtua (VTLS) และเปิดกล่อง Check In (F4) พร้อมทั้งเลือกค่าต่" +
    "าง ๆ เช่น Inhouse use ก่อนรันโปรแกรม";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Barcode (ใช้สำหรับทดสอบทีละ Barcode)";
            // 
            // BatchBarcodeCheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 546);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result_txt);
            this.Controls.Add(this.checkin_all_btn);
            this.Controls.Add(this.txt_filename);
            this.Controls.Add(this.browse_file);
            this.Controls.Add(this.btn_sendbarcode);
            this.Controls.Add(this.textBox);
            this.Name = "BatchBarcodeCheckInForm";
            this.Text = "Barcode CheckIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btn_sendbarcode;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button browse_file;
        private System.Windows.Forms.TextBox txt_filename;
        private System.Windows.Forms.Button checkin_all_btn;
        private System.Windows.Forms.TextBox result_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

