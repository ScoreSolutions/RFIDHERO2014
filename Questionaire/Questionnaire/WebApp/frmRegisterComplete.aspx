<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmRegisterComplete.aspx.cs" Inherits="WebApp_frmRegisterComplete" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>REGISTRATION COMPLETE</title>
    <link id="MyStyleSheet" href="../Template/StyleSheet.css" rel="stylesheet" type="text/css" />
    
    <style type="text/css">

 p.MsoNormal
	{margin-top:0cm;
	margin-right:0cm;
	margin-bottom:10.0pt;
	margin-left:0cm;
	line-height:115%;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	}
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <table border="0" cellpadding="0" cellspacing="0" width="90%" style="border:1px solid #666666" >
            <tr style="height:100px" >
                <td width="100%">
                    <img src="../Image/ConfirmationHeader.jpg" />
                </td>
            </tr>
            <tr><td>&nbsp;</td></tr>
            <tr>
                <td style="padding:0px 20px 0px 20px" align="left" class="Csslbl">
                    <b>เรียนคุณ <asp:Label ID="lblName" runat="server"></asp:Label>,</b><br />
                    ขอบคุณที่ลงทะเบียนกับเรา ชื่อที่ท่านได้ใช้ในการลงทะเบียนเข้าร่วมงาน มีรายละเอียดอยู่ด้านล่าง
                </td>
            </tr>
            <tr>
                <td align="center">
                    <div style="padding: 10px; border: 2px solid #808080;width:350px" >
                        <b>Confirmation Code : </b><asp:Label ID="lblID" runat="server" Text=""  ></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td style="padding:0px 20px 0px 20px" align="left" class="Csslbl">
                    กรุณาพิมพ์หน้านี้เก็บไว้ เพื่อใช้สำหรับติดต่อกับเจ้าหน้าที่หน้างาน <br />
                    ด้วยความนับถือ <br />
                    ผู้ดูแลระบบ (Admin)
                </td>
            </tr>
            <tr>
                <td align="center">
                    <input type="button" value="พิมพ์" style="width:80px" class="CssBtn" onclick="print();" />
                </td>
            </tr>
            <tr><td>&nbsp;</td></tr>
            <tr><td>
                <p align="center" class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;
text-align:center">
                    <b><span lang="TH">กำหนดการจัดงาน</span><span> RFID Hero</span></b><span><o:p></o:p></span></p>
                <p align="center" class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;
text-align:center">
                    <b><span lang="TH">ในวันอังคารที่</span><span> 15 </span><span lang="TH">ตุลาคม</span><span> 
                    2556 </span><span lang="TH">เวลา </span><span>09.00-17.00 </span>
                    <span lang="TH">น</span><span>.</span></b><span><o:p></o:p></span></p>
                <p align="center" class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;
text-align:center">
                    <b><span lang="TH">ณ</span><span> Hall 203 </span><span lang="TH">
                    ศูนย์นิทรรศการและการประชุม ไบเทค บางนา</span></b><span><o:p></o:p></span></p>
                <p align="center" class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;
text-align:center">
                    *******************************************************<o:p></o:p></p>
                <p class="MsoNormal">
                    <b>09.15-09.30<span lang="TH"> น.<span>&nbsp;&nbsp; </span><i>
                    คุณสุทัศน์ ครองชนม์ </i></span></b>
                </p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:34.9pt;margin-bottom:.0001pt;text-indent:36.0pt;line-height:normal">
                    <span lang="TH">ประธานจัดงาน กล่าวถึงวัตถุประสงค์ในการจัดงาน</span></p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:34.9pt;margin-bottom:.0001pt;text-indent:36.0pt;line-height:normal">
                    <span><o:p>&nbsp;</o:p></span></p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:70.9pt;margin-bottom:.0001pt;text-indent:-70.9pt;line-height:normal">
                    <b><span>09.30-09.45 </span><span lang="TH">น.<span>&nbsp;&nbsp; </span><i>
                    คุณสุพันธุ์ มงคลสุธี</i></span></b></p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:70.9pt;margin-bottom:.0001pt;line-height:normal">
                    <span lang="TH">รองประธานสภาอุตสาหกรรมแห่งประเทศไทย และประธานคณะกรรมการบริหาร
                    </span>
                </p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:70.9pt;margin-bottom:.0001pt;line-height:normal">
                    <span lang="TH">สถาบันส่งเสริมความเป็นเลิศทางเทคโนโลยีอาร์เอฟไอ<span>ดีแห่งประเทศไทย 
                    (สลอท.) </span>
                    </span>
                </p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:70.9pt;margin-bottom:.0001pt;line-height:normal">
                    <span lang="TH">กล่าวต้อนรับและเปิดงาน</span></p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:70.9pt;margin-bottom:.0001pt;line-height:normal">
                    <span lang="TH"><o:p>&nbsp;</o:p></span></p>
                <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal">
                    <b>09.45-10.00<span lang="TH"> น. <span>&nbsp;&nbsp; </span><i>ดร.ทวีศักดิ์ 
                    กออนันตกูล</i></span></b></p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:36.0pt;margin-bottom:.0001pt;text-indent:36.0pt;line-height:normal">
                    <span lang="TH">ผู้อำนวยการสำนักงานพัฒนาวิทยาศาสตร์และเทคโนโลยีแห่งชาติ 
                    หรือผู้แทน</span></p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:36.0pt;margin-bottom:.0001pt;text-indent:36.0pt;line-height:normal">
                    <span lang="TH">กล่าวแสดงความยินดีกับผู้จัดงาน</span></p>
                <p class="MsoNormal" style="margin-left:36.0pt;text-indent:36.0pt;line-height:
normal">
                    <o:p>&nbsp;</o:p></p>
                <p class="MsoNormal" style="line-height:150%">
                    <b>10.00-10.30<span lang="TH"> น.</span></b><span lang="TH"><span>&nbsp;&nbsp;&nbsp;
                    </span>ร่วมถ่ายรูปที่ระลึก</span></p>
                <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal">
                    <b>10.30-11.00 <span lang="TH">น.</span></b><span lang="TH"><span>&nbsp;&nbsp;&nbsp;
                    </span>การเสวนาหัวข้อ</span><b><i>”<span lang="TH"> </span>Update RFID 
                    Technology 2013”</i></b></p>
                <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal">
                    <b><i><span>
                    </span></i></b><span lang="TH">โดย ชมรม อาร์ เอฟ ไอ ดี ไทยแลนด์</span></p>
                <p class="MsoNormal" style="line-height:normal">
                    <o:p>&nbsp;</o:p></p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:70.9pt;margin-bottom:.0001pt;text-indent:-70.9pt;line-height:normal">
                    <b>11.00-12.00 <span lang="TH">น.</span></b><span lang="TH"><span>&nbsp;&nbsp;&nbsp;
                    </span>การเสวนาจากผู้ใช้งานจริง หัวข้อ </span><b><i>“<span lang="TH">การประยุกต์ใช้
                    </span>RFID: <span lang="TH">กรณีขอนแก่นมาราธอน</span></i></b>”</p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:70.9pt;margin-bottom:.0001pt;line-height:normal">
                    <i><span lang="TH">โดย คณะกรรมการจัดงานมาราธอนขอนแก่น มหาวิทยาลัยขอนแก่น</span></i></p>
                <p class="MsoNormal" style="margin-left:70.9pt;line-height:normal">
                    <o:p>&nbsp;</o:p></p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:70.9pt;margin-bottom:.0001pt;text-indent:-70.9pt;line-height:normal">
                    <b>12.00-15.45<span lang="TH"> น.</span></b><span lang="TH"><span>&nbsp;&nbsp;
                    </span>การเสวนาหัวข้อ </span><b><i>“<span lang="TH">มุมมองด้านความคุ้มค่า, ปัญหา</span>/<span 
                        lang="TH">อุปสรรค และแนวทางการแก้ปัญหาเทคโนโลยี </span>RFID”</i></b><o:p>&nbsp;</o:p></p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:70.9pt;margin-bottom:.0001pt;line-height:normal">
                    <span lang="TH">โดย ชมรม อาร์ เอฟ ไอ ดี ไทยแลนด์</span></p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:70.9pt;margin-bottom:.0001pt;line-height:normal">
                    <o:p>&nbsp;</o:p></p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:70.9pt;margin-bottom:.0001pt;line-height:normal">
                    <b>12.00-12.45 </b><span lang="TH"><b>น.</b><span>&nbsp;&nbsp;&nbsp;&nbsp;
                    </span>การประยุกต์ใช้เทคโนโลยี </span>RFID <span lang="TH">เพื่อสถานการศึกษา</span></p><br />
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:5.0cm;margin-bottom:.0001pt;text-indent:-70.85pt;line-height:normal">
                    <b>13.00-13.45 </b><span lang="TH"><b>น.</b><span>&nbsp;&nbsp;&nbsp; </span>
                    ร่วมถูก </span>“<span 
                        lang="TH">ประเด็นร้อน </span><span>RFID </span><span lang="TH">แห่งปี </span>
                    <span>2556 : Easy Pass, </span><span lang="TH">รับจำนำข้าว, ถังแก๊ส 
                    และการรบกวนมือถือ </span><span>AIS”</span></p><br />
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:70.9pt;margin-bottom:.0001pt;line-height:normal">
                    <b>14.00-14.45</b><span lang="TH"><b> น.</b><span>&nbsp;&nbsp;&nbsp;&nbsp;
                    </span>การประยุกต์ใช้เทคโนโลยี </span>RFID <span lang="TH">เพื่อ </span>Supply Chain 
                    (Pallet,Warehouse,Production)</p><br />
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:34.9pt;margin-bottom:.0001pt;text-indent:36.0pt;line-height:normal">
                    <b>15.00-15.45 </b><span lang="TH"><b>น.</b><span>&nbsp;&nbsp;&nbsp;&nbsp;
                    </span>การประยุกต์ใช้เทคโนโลยี </span>RFID <span lang="TH">เพื่อการจัดการทรัพย์สิน</span></p><br />
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:34.9pt;margin-bottom:.0001pt;text-indent:36.0pt;line-height:normal">
                    <o:p>&nbsp;</o:p></p>
                <p class="MsoNormal" style="margin-top:0cm;margin-right:0cm;margin-bottom:0cm;
margin-left:34.9pt;margin-bottom:.0001pt;text-indent:36.0pt;line-height:normal">
                    <o:p>&nbsp;</o:p></p>
                <p align="center" class="MsoNormal" style="text-align:center;line-height:150%">
                    <b><i><span>“</span><span lang="TH">เชิญร่วมชมงานแสดงและสาธิตการใช้งานเทคโนโลยี
                    </span><span>RFID </span><span lang="TH">ได้ตลอดทั้งวัน ณ บูธแสดงสินค้า</span></i></b><i><span>”<o:p></o:p></span></i></p>
                </td></tr>
            <tr><td>&nbsp;</td></tr>
            <tr style="height:70px" >
                <td width="100%">
                    <img src="../Image/ConfirmationFooter.jpg" alt="www.scoresolutions.co.th" 
                        title="www.scoresolutions.co.th" onclick="location.href='http://www.scoresolutions.co.th'" />
                </td>
            </tr>
        </table>
        </center>
    </div>
    </form>
</body>
</html>
