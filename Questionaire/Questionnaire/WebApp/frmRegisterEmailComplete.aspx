<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmRegisterEmailComplete.aspx.cs" Inherits="WebApp_frmRegisterComplete" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CONFIRM EMAIL COMPLETE</title>
    <link id="MyStyleSheet" href="../Template/StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css" >
        @font-face 
        {
            font-family: IDAutomationHC39M;
            src: url('../Template/IDAutomationHC39M_Free.eot');
	        src: url('../Template/IDAutomationHC39M_Free.eot?#iefix') format('embedded-opentype'),
	             url('../Template/IDAutomationHC39M_Free.woff') format('woff'),
	             url('../Template/IDAutomationHC39M_Free.ttf') format('truetype'),
	             url('../Template/IDAutomationHC39M_Free.svg#webfont') format('svg');
        }
        .FontBarcode {
            font-family: "IDAutomationHC39M";
        }
        .style7
        {
            height: 19px;
        }
        .style8
        {
            font-size: large;
            font-weight: bold;
        }
        .style11
        {
            width: 120px;
            height: 21px;
        }
        .style12
        {
            height: 21px;
        }
        .style15
        {
            color: #000000;
            text-decoration: none;
            vertical-align: top;
            padding: 1px;
            font-style: normal;
            font-variant: normal;
            font-size: 12px;
            line-height: normal;
            font-family: Arial, "Courier New" , Courier, monospace;
            height: 17px;
        }
        .style16
        {
            height: 17px;
        }
        .style17
        {
            color: #000000;
            text-decoration: none;
            vertical-align: top;
            padding: 1px;
            font-style: normal;
            font-variant: normal;
            font-size: 12px;
            line-height: normal;
            font-family: Arial, "Courier New" , Courier, monospace;
            height: 16px;
        }
        .style18
        {
            height: 16px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <table border="0" cellpadding="0" cellspacing="0" width="90%" style="border:0px solid #666666" >
            <tr style="height:100px" >
                <td width="100%" align="center">
                    <img src="../Image/ConfirmationHeader.jpg" alt="" />
                </td>
            </tr>
            <tr><td>&nbsp;</td></tr>
            <tr>
                <td style="padding:0px 20px 0px 20px; text-align: center;" align="left" 
                    class="Csslbl">
                    <b>เรียนคุณ <asp:Label ID="lblName" runat="server"></asp:Label></b><br />
                    การยืนการการลงทะเบียนสำเร็จ
                </td>
            </tr>
            <tr>
                <td align="center">
                    <div style="padding: 10px; border: 2px solid #808080;width:350px" >
                        <b>Confirmation Code : </b><br />
                        <asp:Label ID="lblID" runat="server" Text="" CssClass="FontBarcode" ></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                        <tr>
                            <td width="50%" align="right" class="style15" style=" font-size:larger" >โทรศัพท์มือถือ(Mobile):</td>
                            <td width="50%" align="left" class="style16" style=" font-size:larger">
                                <asp:Label ID="lblMobileNumber" runat="server" CssClass="Csslbl"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td width="50%" align="right" class="style15" >ชื่อ (Name) :</td>
                            <td width="50%" align="left" class="style16">
                                <asp:Label ID="lblName2" runat="server" CssClass="Csslbl"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style15" >ตำแหน่ง (Position) :</td>
                            <td align="left" class="style16">
                                <asp:Label ID="lblPosition" runat="server" CssClass="Csslbl"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style15" >แผนก(Division) :</td>
                            <td align="left" class="style16">
                                <asp:Label ID="lblDivision" runat="server" CssClass="Csslbl"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style17" >บริษัท(Company) :</td>
                            <td align="left" class="style18">
                                <asp:Label ID="lblCompany" runat="server" CssClass="Csslbl"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style17" >จังหวัด(Province) :</td>
                            <td align="left" class="style18">
                                <asp:Label ID="lblProvince" runat="server" CssClass="Csslbl"></asp:Label>
                            </td>
                        </tr>
                        <tr><td colspan="2" class="style7"></td></tr>
                        <tr><td colspan="2" class="style8" align="center">กำหนดการเสวนา</td></tr>
                        <tr><td colspan="2">&nbsp;</td></tr>
                        <tr>
                            <td colspan="2">
                            <center>
                                <table>
                                    <tr>
                                        <td style="width:120px"  align="center"><b>เวลา</b></td>
                                        <td align="center"><b>หัวข้อเสวนา</b></td>
                                       
                                    </tr>
                                    <tr>
                                        <td class="style11" align="center">11:00-12:00</td>
                                        <td class="style12" align="left">รู้ไหมเราใช้ RFID ทำอะไรบ้าง?</td>
                                        
                                    </tr>
                                    <tr>
                                        <td style="width:120px" align="center">13:00-14:00</td>
                                        <td align="left">การประยุกต์ใช้ RFID เพื่อลดต้นทุนด้านโลจิสติก</td>
                                       
                                    </tr>
                                     <tr>
                                        <td style="width:120px" align="center">14:00-15:00</td>
                                        <td align="left">การประยุกต์ใช้ RFID เพื่อเพิ่มประสิทธิภาพในการให้บริการ</td>
                                        
                                    </tr>
                                    <tr>
                                        <td style="width:120px">&nbsp;</td>
                                        <td>&nbsp;</td>
                                        
                                    </tr>
                                    </table>
                                </center>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <input type="button" value="Print" style="width:80px" class="CssBtn" 
                        onclick="print();" />
                    <input type="button" value="Home" style="width:95px" class="CssBtn" 
                        onClick="location.href='../WebApp/frmRegister2.aspx'" /></td>
            </tr>
            <tr><td>&nbsp;</td></tr>
            <tr style="height:70px" >
                <td width="100%" align="center">
                    <img src="../Image/ConfirmationFooter2.jpg" alt="" />
                </td>
            </tr>
            </table>
        </center>
    </div>
    </form>
</body>
</html>
