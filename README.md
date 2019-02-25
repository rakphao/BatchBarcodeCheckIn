# BatchBarcodeCheckIn

การจัดเก็บสถิติการใช้ทรัพยากรสารสนเทศภายในห้องสมุด (In-House Usage)
ด้วยโปรแกรมป้อนรหัสบาร์โค้ดแบบกลุ่ม (Barcode Batch Check In)
--
รักเผ่า เทพปัน และ ณชญาดา ภิราษร

e-mail: rakphao.the@mfu.ac.th, duangruethai.phi@mfu.ac.th

[ศูนย์บรรณสารและสื่อการศึกษา มหาวิทยาลัยแม่ฟ้าหลวง](http://www.library.mfu.ac.th/th/)


## บทคัดย่อ
ผู้บริหาร บรรณารักษ์และเจ้าหน้าที่ของศูนย์บรรณสารและสื่อการศึกษา มหาวิทยาลัยแม่ฟ้าหลวงได้คำนึงถึงว่าการจัดเก็บสถิติการใช้งานทรัพยากรสารสนเทศที่ใช้งานภายในห้องสมุดโดยไม่ได้ยืมออกนั้นมีความสำคัญ สมควรจัดเก็บสถิติการใช้งานประเภทนี้ไว้  นอกจากนี้ยังมีทรัพยากรสารสนเทศบางประเภทที่ไม่อนุญาตให้ผู้ใช้บริการยืมออกจากห้องสมุด แต่จัดให้ใช้ภายในห้องสมุดเท่านั้น ซึ่งทรัพยากรสารสนเทศประเภทนี้ก็ควรจะมีการบันทึกสถิติการใช้งานด้วยเช่นกัน จึงเห็นสมควรพัฒนาเครื่องมือสำหรับจัดเก็บสถิติการใช้งานทรัพยากรสารสนเทศภายในห้องสมุด  (In-House Usage) เพื่อใช้ในการประเมินคุณค่าทรัพยากรสารสนเทศที่บอกรับ การพิจารณาเพิ่มจำนวนฉบับ (copy) ให้เพียงพอกับความต้องการ ตลอดจนใช้เป็นข้อมูลประกอบการจำหน่ายทรัพยากรสารสนเทศออกจากห้องสมุดต่อไป 

ศูนย์บรรณสารฯ จึงได้พัฒนาโปรแกรมป้อนรหัสบาร์โค้ดแบบกลุ่ม (Barcode Batch Check In) ด้วย .NET Framework (C#) ในรูปแบบ Desktop Application สำหรับช่วยส่งข้อมูลรายการรหัสบาร์โค้ดของทรัพยากรสารสนเทศที่มีการใช้ภายในห้องสมุดที่จัดเก็บในรูปแบบไฟล์ข้อความ (text file) ไปยังหน้า “Check In” แบบ “In-house usage” ของส่วนติดต่อผู้ใช้แบบกราฟิก (GUI) ของโปรแกรมระบบห้องสมุดอัตโนมัติที่ศูนย์บรรณสารฯ ใช้งาน (VTLS)  เป็นการบันทึกรายการทรัพยากรสารสนเทศที่ใช้งานภายในห้องสมุดเข้าสู่ฐานข้อมูลของระบบห้องสมุดอัตโนมัติครั้งละจำนวนมาก 

จากการประยุกต์ใช้งานโปรแกรมป้อนรหัสบาร์โค้ดแบบกลุ่มที่พัฒนาขึ้น หลังจากมีการทดสอบและปรับแต่งโปรแกรมหลายครั้ง พบว่ามีความสะดวกรวดเร็ว ถูกต้องและแม่นยำในการจัดเก็บสถิติการใช้งานทรัพยากรสารสนเทศ ส่งผลให้ฝ่ายบริการสารนิเทศได้ข้อมูลประกอบการประเมินคุณค่าทรัพยากรสารสนเทศเพื่อรายงานผู้บริหาร และสามารถใช้เป็นข้อมูลให้ฝ่ายพัฒนาทรัพยากรเพิ่มจำนวนฉบับ (copy) ให้เพียงพอกับความต้องการ และใช้ประกอบการจำหน่ายออกทรัพยากรสารสนเทศของห้องสมุดต่อไป 

คำสำคัญ : สถิติการใช้งานทรัพยากรสารสนเทศ, .NET Framework

## ABSTRACT

Administrators and librarians of the Learning Resources and Education Media Center, Mae Fah Luang University, consider that it is important to store statistics on the usage of library resources that are used in the library without having to borrow them (in-house use). There are also some types of resources that only for use in the library. Usage statistics of these type resources should also be kept as well. It is therefore advisable to develop a tool for collecting in-house usage statistics of library resources in order to evaluate the value of information resources and make consideration to increase the number of copies to meet the need. These statistics are also included to make a decision to withdrawn unwanted items from the library.

“Barcode Batch Check In” which is desktop application has been developed with the .NET Framework (C#). It is for importing barcodes of in-house use items which are stored in a text file. Then, this software will enter these barcodes to "In-house usage Check-In" window of the graphical user interface (GUI) of VTLS which is the client of the library automation system. It makes it possible to record in-house usage of library resources into the library automation system’s database in batch.

Using this “Barcode Batch Check In” developed program, after testing and refining the program several times, supports library staffs to collect in-house usage statistics of library resources conveniently and accurately. As a result, the library has statistical information to assess the value of information resources to report to the board.  These statistics are also included to make consideration to increase the number of copies to meet the need or withdrawn unwanted items from the library.
	
Keywords
In-house usage statistic, .NET Framework
  
---
นำเสนอในการประชุมวิชาการระดับชาติ PULINET ครั้งที่ 9 กลุ่มการจัดการสารสนเทศ เทคโนโลยีสารสนเทศ และนวัตกรรม (Information Technology and Innovation Management)

