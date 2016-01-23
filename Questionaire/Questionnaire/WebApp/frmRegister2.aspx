<%@ Page Title="" Language="C#" MasterPageFile="~/Template/ContentMasterPage.master" AutoEventWireup="true" CodeFile="frmRegister2.aspx.cs" Inherits="WebApp_frmRegister" %>
<%@ Register src="../UserControls/txtBox.ascx" tagname="txtBox" tagprefix="uc1" %>
<%@ Register src="../UserControls/cmbComboBox.ascx" tagname="cmbComboBox" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        .style1
        {
            color: #FF0000;
            font-size: medium;
            font-weight: bold;
        }
        .style2
        {
            font-size: medium;
            font-weight: bold;
        }
    </style>

    <script language="javascript" type="text/javascript">
        function SetFocus() {
            document.getElementById("<%=txtFirstName.ClientID %>").focus();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table border="0" cellpadding="0" cellspacing="0" width="100%" height="100%" >
    <tr>
        <td align="center" class="CssHead" >
            <asp:Label ID="lblPageName" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr><td>
        <asp:Label ID="lblid" runat="server" Text="0" Visible="False"></asp:Label>
        </td></tr>
    <tr>
        <td align="center" >
            <table border="0" cellpadding="0" cellspacing="0" width="80%" >
              
                <tr>
                    <td  class="Csslbl" align="right" >คำนำหน้า :<br />Title</td>
                    <td class="Csslbl" align="left" colspan="3" style="padding-left:10px"  >
                        <table>
                            <tr>
                                <td>
                                    <asp:RadioButtonList ID="rdiTitle" runat="server" RepeatColumns="3" RepeatDirection="Horizontal"
                                        RepeatLayout="Flow" AutoPostBack="true" OnSelectedIndexChanged="rdiTitle_SelectedIndexChange">
                                        <asp:ListItem Value="MR" Text="นาย/Mr.&nbsp;&nbsp;&nbsp;"></asp:ListItem>
                                        <asp:ListItem Value="MRS" Text="นาง/Mrs.&nbsp;&nbsp;&nbsp;"></asp:ListItem>
                                        <asp:ListItem Value="MS" Text="นางสาว/Ms.&nbsp;&nbsp;&nbsp;"></asp:ListItem>
                                        <asp:ListItem Value="OTHERS" Text="อื่นๆ/Others,Please Specify(โปรดระบุ)&nbsp;"></asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                                <td valign="top">
                                <asp:Label ID="Label13" runat="server" Text="*" ForeColor="Red"></asp:Label>
                                </td>
                            </tr>
                        </table>
                        
                        
                        <uc1:txtBox ID="txtTitleOthers" runat="server" Width="250px" 
                            Enabled="false" MaxLength="255" />
                        
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">ชื่อ :<br />Name</td>
                    <td colspan="3" align="left" style="padding-left:10px">
                        <uc1:txtBox ID="txtFirstName" runat="server" Width="160px" 
                            WatermarkText="ชื่อ (First Name)" MaxLength="255"  />
                        
                        &nbsp;&nbsp;
                        <%--<asp:Checkbox ID="Chk17" runat="server" Text="17 ผู้ค้าส่ง</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Wholesaler" GroupName="PartA" />--%>
                        <uc1:txtBox ID="txtLastName" runat="server" Width="160px" 
                            WatermarkText="นามสกุล (Last Name)" MaxLength="255"  />
                        <asp:Label ID="Label3" runat="server" Text="*" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">ตำแหน่ง :<br />Position</td>
                    <td colspan="3" align="left" style="padding-left:10px">
                        <uc1:txtBox ID="txtPosition" runat="server" Width="480px" MaxLength="255"  />&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">แผนก :<br />Division</td>
                    <td colspan="3" align="left" style="padding-left:10px">
                        <uc1:txtBox ID="txtDivition" runat="server" Width="480px" MaxLength="255"  />&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">บริษัท :<br />Company</td>
                    <td colspan="3" align="left" style="padding-left:10px">
                        <uc1:txtBox ID="txtCompany" runat="server" Width="480px" MaxLength="255"  />&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">ที่อยู่  :<br />Address</td>
                    <td colspan="3" align="left" style="padding-left:10px">
                        <uc1:txtBox ID="txtAddress" runat="server" Width="480px" MaxLength="255"  />
                          <asp:Label ID="Label4" runat="server" Text="*" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">จังหวัด  :<br />City</td>
                    <td align="left" style="padding-left:10px">
                        <uc1:txtBox ID="txtCity" runat="server" Width="180px" MaxLength="255"  />&nbsp;&nbsp;
                    </td>
                    <td class="Csslbl" align="right"><br /></td>
                    <td align="left" >
                        <%--  <tr>
                                            <td class="Csslbl" >
                                                <asp:CheckBox ID="ChkE12" runat="server" Text="12 ระบบจัดการสินค้าคงคลัง<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;WMSOne Solutions" />
                                            </td>
                                        </tr>--%>
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">ประเทศ :<br />Country</td>
                    <td align="left" style="padding-left:10px">
                         <table border="0" cellpadding="0" cellspacing="0" width="530px">
                            <tr>
                                <td width="110px" align="left"><uc1:txtBox ID="txtCountry" runat="server" Width="180px" MaxLength="255"  /> </td>
                                <td width="100px" align="right" class="Csslbl">
                                    <asp:Label ID="Label9" runat="server" Text="รหัสไปรษณีย์ :<br /> Postal Code" 
                                        Width="150px"></asp:Label>
                                </td>
                                <td width="110px" align="left"><uc1:txtBox ID="txtZipCode" runat="server" Width="180px" MaxLength="5" 
                            TextKey="TextInt" /></td>
                               
                            </tr>
                        </table>
                          
                    </td>
                    <td class="Csslbl" align="right"></td>
                    <td align="left" style="padding-left:10px">
                      
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">โทรศัพท์  :<br />Telephone</td>
                    <td align="left" colspan="3"  style="padding-left:10px">
                        <table border="0" cellpadding="0" cellspacing="0" width="520px">
                            <tr>
                                <td width="110px" align="left"><uc1:txtBox ID="txtTelNumber" runat="server" 
                                        Width="100px" MaxLength="10" TextKey="TextInt"  /></td>
                                <td width="100px" align="right" class="Csslbl">โทรศัพท์มือถือ  :<br />Mobile</td>
                                <td width="110px" align="left">&nbsp;<uc1:txtBox ID="txtMobileNo" runat="server" 
                                        Width="100px" MaxLength="10" TextKey="TextInt"  /></td>
                                <td><asp:Label ID="Label5" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                                <td width="60px" class="Csslbl" align="right">โทรสาร :<br />Fax</td>
                                <td align="left">&nbsp;
                                    <uc1:txtBox ID="txtFaxNumber" runat="server" Width="110px" MaxLength="10" 
                                        TextKey="TextInt"  />
                                </td>
                            </tr>
                        </table>
                          
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">อีเมล์ :<br />E-mail</td>
                    <td align="left" style="padding-left:10px">
                       
                          <table border="0" cellpadding="0" cellspacing="0" width="500px">
                            <tr>
                                <td width="110px" align="left"> <uc1:txtBox ID="txtEmail" runat="server" 
                                        Width="180px" MaxLength="255"  /> </td>
                                <td ><asp:Label ID="Label6" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                                <td width="100px" align="right" class="Csslbl">
                                    <asp:Label ID="Label10" runat="server" Text="เว็บไซต์ :<br />Website" 
                                        Width="150px"></asp:Label>
                                </td>
                                <td width="110px" align="left"><uc1:txtBox ID="txtWebSite" runat="server" 
                                        Width="180px" MaxLength="255"  /></td>
                               
                            </tr>
                        </table>
                        
                    </td>
                    <td class="Csslbl" align="right"></td>
                    <td align="left" style="padding-left:10px">
                        
                    </td>
                </tr>
                <%--<tr>
                    <td class="Csslbl" align="right"></td>
                    <td align="left" class="Csslbl" colspan="3" >&nbsp;
                        <uc1:txtBox ID="txtRegisteredCapital" runat="server" Width="160px"  />บาท(Bath)
                    </td>
                </tr>--%>
                <tr>
                    <td class="Csslbl" align="right">
                        <asp:Label ID="Label7" runat="server" 
                            Text="ยอดขายประจำปี 2013 :<br />Annual Sale Value 2013" Width="140px"></asp:Label>
                    </td>
                    <td align="left" class="Csslbl"  style="padding-left:10px">
          
                         <table border="0" cellpadding="0" cellspacing="0"  width="480px">
                            <tr>
                                <td  width="110px" align="left" >
                                <asp:RadioButtonList ID="rdAnnualSale" runat="server" RepeatColumns="1" RepeatDirection="Vertical"
                                        RepeatLayout="Flow"  OnSelectedIndexChanged="rdiTitle_SelectedIndexChange" Width="215">
                                        <asp:ListItem Value="01" Text="น้อยกว่า 20 ล้านบาท (< 20 million baht)"></asp:ListItem>
                                        <asp:ListItem Value="02" Text="มากกว่า 20 ล้านบาท  (> 20 million baht)"></asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                                 <td align="left"><asp:Label ID="Label8" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                                <td   align="right"  class="Csslbl">
                                    <asp:Label ID="Label12" runat="server" Text="ช่วงเวลาเข้าร่วมงาน :<br />Period Time" 
                                        Width="150px"></asp:Label>
                                </td>
                                <td   width="110px" align="left">
                                    <asp:CheckboxList ID="rdPeriod" runat="server" RepeatDirection="Horizontal" Width="220px">
                                        <asp:ListItem Value="1">ช่วงเช้า(morning)</asp:ListItem>
                                        <asp:ListItem Value="2">ช่วงบ่าย(afternoon)</asp:ListItem>
                                    </asp:CheckboxList>
                                </td>
                                <td align="left"><asp:Label ID="Label11" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                               
                            </tr>
                            <tr>
                                <td  align="right" colspan="4"  style=" padding-right:50px">
                       
                        <asp:Label ID="Label2" runat="server" ForeColor="Red" 
                            Text="* การเข้าร่วมงานตลอดทั้งวันท่านจะได้รับสิทธิ์ในการลุ้นรับทองคำ" 
                            Font-Size="11pt" Width="400px" ></asp:Label>
                                </td>
                               
                            </tr>
                        </table>            
                                    
                                    
                       
                    </td>
                    <td class="Csslbl" align="right">
                      
                    </td>
                    <td align="left" valign="top"  class="Csslbl" >
                       
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">&nbsp;</td>
                    <td align="left" class="Csslbl" style="padding-left: 200px"  >
                       
                        &nbsp;</td>
                    <td class="Csslbl" align="right" colspan="2">
                        &nbsp;</td>
                </tr>
            </table>
            
        </td>
    </tr>
    <tr><td>&nbsp;</td></tr>
    <tr>
        <td align="center" class="CssHead" style="background-color: #C0C0C0" >
            <asp:Label ID="Label1" runat="server" Text="- PLEASE COMPLETE ALL SECTION -" ></asp:Label>
        </td>
    </tr>
    <tr>
        <td align="left" width="100%">
            <asp:UpdatePanel ID="u1" runat="server">
            <ContentTemplate>
            <table  width="100%">
                <tr>
                    <td valign="top">
                        <table width="100%">
                            <tr>
                                <td width="50%" valign="top">
                                    <table>
                                        <tr>
                                            <td class="Csslbl" >
                                                A.Please tick Type(s) of your business:<br />
                                                กรุณาระบุประเภทธุรกิจของท่าน 
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <table>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA01" runat="server" Text="01 ตัวแทนจำหน่าย</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Agent" GroupName="PartA"  />
                                                        </td>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA02" runat="server" Text="02 สถานศึกษา</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Academy" GroupName="PartA" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA03" runat="server" Text="03 สมาคม</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Association" GroupName="PartA" />
                                                        </td>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA04" runat="server" Text="04 ผู้ค้าส่ง </br> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Chain Store/Wholesaler" GroupName="PartA" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA05" runat="server" Text="05 ห้างสรรพสินค้า</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Department Store" GroupName="PartA" />
                                                        </td>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA06" runat="server" Text="06 ผู้จัดจำหน่าย</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Distributor" GroupName="PartA" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA07" runat="server" Text="07 ธุรกิจออนไลน์ <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; E-Business" GroupName="PartA" />
                                                        </td>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA08" runat="server" Text="08 ผู้ส่งออก</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Exporter" GroupName="PartA" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA09" runat="server" 
                                                                Text="09 หน่วยงานราชการ&lt;/br /&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Government Service" 
                                                                GroupName="PartA" />
                                                        </td>
                                                        <td>
                                                         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                            <ContentTemplate>
                                                            <asp:Checkbox ID="ChkA10" runat="server" Text="10 การขนส่ง(ระบุ)</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Logistics" GroupName="PartA"  AutoPostBack="true"  OnCheckedChanged="chkA10_CheckedChanged"/>
                                                            <asp:TextBox ID="txtA10" runat="server" Width="140px" Enabled="false"></asp:TextBox>
                                                            </ContentTemplate>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA11" runat="server" Text="11 ผู้ผลิต</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manufacturer" GroupName="PartA" />
                                                        </td>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA12" runat="server" Text="12 พ่อค้าขายปลีก</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Retailer" GroupName="PartA" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA13" runat="server" Text="13 ร้านค้าปลีก</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Retail Outlet" GroupName="PartA" />
                                                        </td>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA14" runat="server" Text="14 อุตสาหกรรมบริการ</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Service Industry" GroupName="PartA" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA15" runat="server" Text="15 ร้านค้าพิเศษ</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Specialty Store" GroupName="PartA" />
                                                        </td>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA16" runat="server" Text="16 ซื้อขายและนำเข้า</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Trading / Importer" GroupName="PartA" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <%--<asp:Checkbox ID="Chk17" runat="server" Text="17 ผู้ค้าส่ง</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Wholesaler" GroupName="PartA" />--%>
                                                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:CheckBox ID="ChkA17" runat="server" Text="17 อื่นๆ ระบุ</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Others"
                                                                        GroupName="PartA" AutoPostBack="true" OnCheckedChanged="chkA17_CheckedChanged" />
                                                                    <asp:TextBox ID="txtA17" runat="server" Width="150px" Enabled="false"></asp:TextBox>
                                                                </ContentTemplate>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td class="Csslbl" >
                                                B.How did you first learn about the fair?:<br />
                                                ท่านทราบข่าวงานนี้ได้อย่างไร
                                            </td>
                                        </tr>
                                         <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                             <asp:CheckBox ID="ChkB01" runat="server" 
                                                    Text="01 เอกสารบัตรเชิญ / จดหมายจากผู้จัดงาน &lt;br/&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Direct mail / Invitation from organizer" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                             <asp:CheckBox ID="ChkB02" runat="server" Text="02 อีเมล์จากผู้จัดงาน <br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email from organizer" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                             <asp:CheckBox ID="ChkB03" runat="server" Text="03 อินเตอร์เน็ต <br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Internet" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                             <asp:CheckBox ID="ChkB04" AutoPostBack="true" 
                                                    OnCheckedChanged="chkB04_CheckedChanged" runat="server" 
                                                    Text="04 ชุมชนออนไลน์ กรุณาเลือก&lt;br/&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Social Media. Please tick" /><br />
                                             <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td style="padding-left:20px"><asp:RadioButton ID="rdiChkB04Facebook" AutoPostBack="true" OnCheckedChanged="rdiChkB04Facebook_CheckedChanged" runat="server" Text="Facebook" GroupName="Chk22" /> </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <asp:UpdatePanel ID="upChk22" runat="server">
                                                    <ContentTemplate>
                                                        <tr>
                                                            <td style="padding-left:20px"><asp:RadioButton ID="rdiB04Other" runat="server"  OnCheckedChanged="rdiB04Other_CheckedChanged" Text="อื่นๆ (กรุณาระบุ)<br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Other,please specify" GroupName="Chk22" AutoPostBack="true" /></td>
                                                            <td>
                                                                <asp:TextBox ID="txtB04" runat="server" Width="140px" Enabled="false"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                             </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkB05" OnCheckedChanged="chkB05_CheckedChanged" runat="server" 
                                                    Text="05 นิตยสาร &lt;br/&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Trade Magazine" 
                                                    AutoPostBack="true"  />
                                            <asp:TextBox ID="txtB05" runat="server" Width="240px" Enabled="false"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkB06" runat="server" OnCheckedChanged="chkB06_CheckedChanged" Text="06 หนังสือพิมพ์ <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Newspapers" AutoPostBack="true" />
                                            <asp:TextBox ID="txtB06" runat="server" Width="260px" Enabled="false"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkB07" runat="server" Text="07 ป้ายโฆษณา <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Street Banners" AutoPostBack="true"  />
                                            </td>
                                        </tr>
                                         <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <asp:CheckBox ID="ChkB08" runat="server" Text="08 โทรทัศน์ /  วิทยุ <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  TV / Radio" />
                                            </td>
                                        </tr>
                                         <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <asp:CheckBox ID="ChkB09" runat="server" Text="09 ผู้ร่วมงาน / เพื่อน <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Colleagues / Friends" />
                                            </td>
                                        </tr>
                                         <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <asp:CheckBox ID="ChkB10" runat="server" Text="10 สมาคม / สถาบัน <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  Trade Associations / Institutes" />
                                            </td>
                                        </tr>
                                         <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <asp:CheckBox ID="ChkB11" runat="server" Text="11 ผู้แสดงสินค้า /  ผู้จัดงาน <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  Exhibitors of the Fair" AutoPostBack="true"  />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <asp:CheckBox ID="ChkB12" runat="server" Text="12 สภาอุตสาหกรรมแห่งประเทศไทย <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Invitation From The Federation of Thai Industries"  />
                                             </td>
                                        </tr>
                                         <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <asp:CheckBox ID="ChkB13" runat="server" Text="13 สถาบันส่งเสริมความเป็นเลิศทางเทคโนโลยี RFID แห่งประเทศไทย <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Invitation From RFID Institute of Thailand"  />
                                             </td>
                                        </tr>
                                         <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <asp:CheckBox ID="ChkB14" runat="server" 
                                                    OnCheckedChanged="chkB14_CheckedChanged" 
                                                    Text="14 อื่นๆ &lt;br/&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Others (กรุณาระบุ)(Please Specify) " 
                                                    AutoPostBack="true"  />
                                                <asp:TextBox ID="txtB14" runat="server" Width="288px" Enabled="false"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td class="Csslbl" >
                                                C.Please indicate the purpose(s) of your visit?<br />
                                                กรุณาระบุวัตถุประสงค์ของการเข้าชมงาน
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkC01" runat="server" 
                                                    Text="01 หาข้อมูลเกี่ยวกับเทคโนโลยี &lt;br/&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Gather Information" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                             <asp:CheckBox ID="ChkC02" runat="server" Text="02 ต้องการติดต่อผู้ขาย / ผู้ผลิต</br> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Establish contact / Visit suppliers" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkC03" runat="server" Text="03 ศึกษาข้อมูลเพื่อเข้าร่วมงานในครั้งต่อไป <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Evaluate the show for future participation" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkC04" runat="server" Text="04 สั่งซื้อสินค้า <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Place orders" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkC05" runat="server" Text="05 หาตัวแทนจำหน่าย <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Seek representatives" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkC06" runat="server" Text="06 เพื่อหาแหล่งจำหน่าย / บริการ <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Source products / service" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkC07" runat="server" Text="07 อื่นๆ(กรุณาระบุ) <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Others(Please specify)" AutoPostBack="true"  OnCheckedChanged="chkC07_CheckedChanged"/>
                                            <asp:TextBox ID="txtC07" runat="server" Width="200px" Enabled="false"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td class="Csslbl" >
                                                 D.Is this the first visit by your company to the fair?<br />
                                                 ท่านหรือบริษัทของท่านเข้าเยี่ยมชมงานนี้ครั้งแรกใช่หรือไม่
                                            </td>
                                           
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px" >
                                            <asp:CheckBox ID="ChkD01" runat="server" Text="01 .ใช่ (Yes)"  AutoPostBack="true" OnCheckedChanged="chkD01_CheckedChanged"/>
                                           
                                            
                                            </td>
                                        </tr>
                                        <tr><td  class="Csslbl" style="padding-left: 20px">
                                         <asp:CheckBox ID="ChkD02" runat="server" Text="02 ไม่ใช่ (No) กรุณาระบุ(Please specify)" Wrap="true" AutoPostBack="true"  OnCheckedChanged="chkD02_CheckedChanged"/>
                                              &nbsp;<asp:TextBox ID="txtD02" runat="server" Width="234px" Wrap="true" Enabled="false"></asp:TextBox>
                                        </td></tr>
                                    </table>
                                </td>
                            </tr>
                            
                        </table>
                    
                    </td>
                    <td valign="top" width="50%">
                        <table>
                            <tr>
                                <td class="Csslbl" >
                                    E. What is the product/service of your interest?<br />
                                    กรุณาระบุประเภทสินค้าหรือบริการที่ท่านสนใจ
                                </td>
                            </tr>
                            <tr>
                                <td class="Csslbl" style="padding-left: 40px">
                                    <table>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE01" runat="server" Text="01 ระบบบริหารจัดการคลังสินค้า<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Warehouse Management System" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE02" runat="server" Text="02 ระบบบริหารจัดการยานพาหนะ<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Vehicle Management System" />                                         
                                            </td
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE03" runat="server" Text="03 ระบบรักษาความปลอดภัย<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Security System" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE04" runat="server" Text="04 ระบบตรวจสอบการผลิต<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Production Tracking System" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE05" runat="server" Text="05 ระบบบริหารจัดการสินทรัพย์<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Asset Management System" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE06" runat="server" Text="06 ระบบสารบรรณอิเล็กทรอนิกส์<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;e-Document System" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE07" runat="server" Text="07 ระบบการจัดการศูนย์อาหาร/Canteen<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Food Court management System" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE08" runat="server" Text="08 ระบบบริหารจัดการผู้เข้าเยี่ยม <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Visitor Management" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" >
                                                <asp:CheckBox ID="ChkE09" runat="server" Text="09 ระบบบริหารจัดการพาเลท  <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Pallet Management" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" >
                                                <asp:CheckBox ID="ChkE10" runat="server" Text="10 RFID เพื่อการศึกษา<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RFID for Education" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" >
                                                <asp:CheckBox ID="ChkE11" runat="server" Text="11 RFID เพื่อการกีฬาและความบันเทิง<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RFID for Sport & Entertainment" />
                                            </td>
                                        </tr>
                                      <%--  <tr>
                                            <td class="Csslbl" >
                                                <asp:CheckBox ID="ChkE12" runat="server" Text="12 ระบบจัดการสินค้าคงคลัง<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;WMSOne Solutions" />
                                            </td>
                                        </tr>--%>
                                        <tr>
                                            <td class="Csslbl" >
                                                <asp:CheckBox ID="ChkE12" runat="server" Text="12 เทคโนโลยีบนมือถือ /แท็บเล็ต <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Mobile / Tablet Enterprise solutions" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" >
                                                <asp:CheckBox ID="ChkE13" runat="server" 
                                                    Text="13 เทคโนโลยีเกี่ยวกับการติดตามตำแหน่งด้วย GPRS &lt;br/&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;GPS Tracking Solutions" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                             <tr>
                                <td class="Csslbl" style="padding-left: 40px">                                  
                                    <table>
                                        <tr>
                                            <td>
                                            <asp:CheckBox ID="ChkE14" runat="server" Text="14 ระบบการทำงานเครื่องแบบอัตโนมัติ <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Automation System" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                             <asp:CheckBox ID="ChkE15" runat="server" Text="15 เทคโนโลยีเครื่องพิมพ์/บาร์โค้ด และ RFID<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Barcode & RFID Printer and Reader" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            <asp:CheckBox ID="ChkE16" runat="server" Text="16 เทคโนโลยีการออกแบบและผลิต RFID<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Design and Manufacture RFID Technology " />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE17" runat="server" 
                                                    Text="17 RFID  สำหรับระบบงาน  โรงแรม ,อพาร์ทเม้นท์ ,ที่อยู่อาศัย &lt;br /&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RFID  For  Hotel, Apartment, Residential " />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE18" runat="server" 
                                                    Text="18 RFID สำหรับระบบงานเกี่ยวกับสุขภาพ &lt;/br&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RFID For Healthcare" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE19" runat="server" 
                                                    Text="19 RFID สำหรับระบบงานซักอบรีด&lt;/br&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RFID For Laundry&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style2">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style1">
                                                *** หมายเหตุ<br />
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; กรุณาระบุสิ่งที่สนใจอย่างน้อย 5 จุด เพื่อรับรางวัล</td>
                                        </tr>
                                        <tr>
                                            <td class="style2">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr><td><br /></td></tr>
    <tr>
        <td align="center">
            <asp:UpdatePanel ID="u2" runat="server">
                <ContentTemplate>
                    <asp:Button ID="btnSave" Runat="server" Text="Save" CssClass="CssBtn" Width="80px" OnClientClick="SetFocus()" OnClick="btnSave_Click" /> 
                    &nbsp; 
                    <asp:Button ID="btnClear" Runat="server" Text="Clear" CssClass="CssBtn" Width="80px" OnClick="btnClear_Click" />
                    &nbsp;
                    <asp:Button ID="btnBack" Runat="server" CssClass="CssBtn" 
                        OnClick="btnBack_Click" Text="Home" Width="80px" Visible="false" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr><td><br /></td></tr>
    <tr><td><br /></td></tr>
    <tr><td><br /></td></tr>
</table>
<!-- Start counter code -->

<!-- hitwebcounter Code START -->
<a href="http://www.hitwebcounter.com/" target="_blank">
<img src="http://hitwebcounter.com/counter/counter.php?page=5782958&style=0006&nbdigits=5&type=page&initCount=0" title="" Alt=""   border="0" >
</a><br/>
<!-- hitwebcounter.com --><a href="http://www.hitwebcounter.com/" title="Hitwebcounter.com" 
target="_blank" style="font-family: Arial, Helvetica, sans-serif; 
font-size: 12px; color: #6B706A; text-decoration: underline ;"><strong>Hitwebcounter.com</strong>
</a>   
  
  

<!-- End counter code -->
</asp:Content>

