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
                    <td  class="Csslbl" align="right" >�ӹ�˹�� :<br />Title</td>
                    <td class="Csslbl" align="left" colspan="3" style="padding-left:10px"  >
                        <table>
                            <tr>
                                <td>
                                    <asp:RadioButtonList ID="rdiTitle" runat="server" RepeatColumns="3" RepeatDirection="Horizontal"
                                        RepeatLayout="Flow" AutoPostBack="true" OnSelectedIndexChanged="rdiTitle_SelectedIndexChange">
                                        <asp:ListItem Value="MR" Text="���/Mr.&nbsp;&nbsp;&nbsp;"></asp:ListItem>
                                        <asp:ListItem Value="MRS" Text="�ҧ/Mrs.&nbsp;&nbsp;&nbsp;"></asp:ListItem>
                                        <asp:ListItem Value="MS" Text="�ҧ���/Ms.&nbsp;&nbsp;&nbsp;"></asp:ListItem>
                                        <asp:ListItem Value="OTHERS" Text="����/Others,Please Specify(�ô�к�)&nbsp;"></asp:ListItem>
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
                    <td class="Csslbl" align="right">���� :<br />Name</td>
                    <td colspan="3" align="left" style="padding-left:10px">
                        <uc1:txtBox ID="txtFirstName" runat="server" Width="160px" 
                            WatermarkText="���� (First Name)" MaxLength="255"  />
                        
                        &nbsp;&nbsp;
                        <%--<asp:Checkbox ID="Chk17" runat="server" Text="17 �������</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Wholesaler" GroupName="PartA" />--%>
                        <uc1:txtBox ID="txtLastName" runat="server" Width="160px" 
                            WatermarkText="���ʡ�� (Last Name)" MaxLength="255"  />
                        <asp:Label ID="Label3" runat="server" Text="*" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">���˹� :<br />Position</td>
                    <td colspan="3" align="left" style="padding-left:10px">
                        <uc1:txtBox ID="txtPosition" runat="server" Width="480px" MaxLength="255"  />&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">Ἱ� :<br />Division</td>
                    <td colspan="3" align="left" style="padding-left:10px">
                        <uc1:txtBox ID="txtDivition" runat="server" Width="480px" MaxLength="255"  />&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">����ѷ :<br />Company</td>
                    <td colspan="3" align="left" style="padding-left:10px">
                        <uc1:txtBox ID="txtCompany" runat="server" Width="480px" MaxLength="255"  />&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">�������  :<br />Address</td>
                    <td colspan="3" align="left" style="padding-left:10px">
                        <uc1:txtBox ID="txtAddress" runat="server" Width="480px" MaxLength="255"  />
                          <asp:Label ID="Label4" runat="server" Text="*" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">�ѧ��Ѵ  :<br />City</td>
                    <td align="left" style="padding-left:10px">
                        <uc1:txtBox ID="txtCity" runat="server" Width="180px" MaxLength="255"  />&nbsp;&nbsp;
                    </td>
                    <td class="Csslbl" align="right"><br /></td>
                    <td align="left" >
                        <%--  <tr>
                                            <td class="Csslbl" >
                                                <asp:CheckBox ID="ChkE12" runat="server" Text="12 �к��Ѵ����Թ��Ҥ���ѧ<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;WMSOne Solutions" />
                                            </td>
                                        </tr>--%>
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">����� :<br />Country</td>
                    <td align="left" style="padding-left:10px">
                         <table border="0" cellpadding="0" cellspacing="0" width="530px">
                            <tr>
                                <td width="110px" align="left"><uc1:txtBox ID="txtCountry" runat="server" Width="180px" MaxLength="255"  /> </td>
                                <td width="100px" align="right" class="Csslbl">
                                    <asp:Label ID="Label9" runat="server" Text="������ɳ��� :<br /> Postal Code" 
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
                    <td class="Csslbl" align="right">���Ѿ��  :<br />Telephone</td>
                    <td align="left" colspan="3"  style="padding-left:10px">
                        <table border="0" cellpadding="0" cellspacing="0" width="520px">
                            <tr>
                                <td width="110px" align="left"><uc1:txtBox ID="txtTelNumber" runat="server" 
                                        Width="100px" MaxLength="10" TextKey="TextInt"  /></td>
                                <td width="100px" align="right" class="Csslbl">���Ѿ����Ͷ��  :<br />Mobile</td>
                                <td width="110px" align="left">&nbsp;<uc1:txtBox ID="txtMobileNo" runat="server" 
                                        Width="100px" MaxLength="10" TextKey="TextInt"  /></td>
                                <td><asp:Label ID="Label5" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                                <td width="60px" class="Csslbl" align="right">����� :<br />Fax</td>
                                <td align="left">&nbsp;
                                    <uc1:txtBox ID="txtFaxNumber" runat="server" Width="110px" MaxLength="10" 
                                        TextKey="TextInt"  />
                                </td>
                            </tr>
                        </table>
                          
                    </td>
                </tr>
                <tr>
                    <td class="Csslbl" align="right">������ :<br />E-mail</td>
                    <td align="left" style="padding-left:10px">
                       
                          <table border="0" cellpadding="0" cellspacing="0" width="500px">
                            <tr>
                                <td width="110px" align="left"> <uc1:txtBox ID="txtEmail" runat="server" 
                                        Width="180px" MaxLength="255"  /> </td>
                                <td ><asp:Label ID="Label6" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                                <td width="100px" align="right" class="Csslbl">
                                    <asp:Label ID="Label10" runat="server" Text="���䫵� :<br />Website" 
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
                        <uc1:txtBox ID="txtRegisteredCapital" runat="server" Width="160px"  />�ҷ(Bath)
                    </td>
                </tr>--%>
                <tr>
                    <td class="Csslbl" align="right">
                        <asp:Label ID="Label7" runat="server" 
                            Text="�ʹ��»�Шӻ� 2013 :<br />Annual Sale Value 2013" Width="140px"></asp:Label>
                    </td>
                    <td align="left" class="Csslbl"  style="padding-left:10px">
          
                         <table border="0" cellpadding="0" cellspacing="0"  width="480px">
                            <tr>
                                <td  width="110px" align="left" >
                                <asp:RadioButtonList ID="rdAnnualSale" runat="server" RepeatColumns="1" RepeatDirection="Vertical"
                                        RepeatLayout="Flow"  OnSelectedIndexChanged="rdiTitle_SelectedIndexChange" Width="215">
                                        <asp:ListItem Value="01" Text="���¡��� 20 ��ҹ�ҷ (< 20 million baht)"></asp:ListItem>
                                        <asp:ListItem Value="02" Text="�ҡ���� 20 ��ҹ�ҷ  (> 20 million baht)"></asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                                 <td align="left"><asp:Label ID="Label8" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                                <td   align="right"  class="Csslbl">
                                    <asp:Label ID="Label12" runat="server" Text="��ǧ������������ҹ :<br />Period Time" 
                                        Width="150px"></asp:Label>
                                </td>
                                <td   width="110px" align="left">
                                    <asp:CheckboxList ID="rdPeriod" runat="server" RepeatDirection="Horizontal" Width="220px">
                                        <asp:ListItem Value="1">��ǧ���(morning)</asp:ListItem>
                                        <asp:ListItem Value="2">��ǧ����(afternoon)</asp:ListItem>
                                    </asp:CheckboxList>
                                </td>
                                <td align="left"><asp:Label ID="Label11" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                               
                            </tr>
                            <tr>
                                <td  align="right" colspan="4"  style=" padding-right:50px">
                       
                        <asp:Label ID="Label2" runat="server" ForeColor="Red" 
                            Text="* �����������ҹ��ʹ����ѹ��ҹ�����Ѻ�Է���㹡������Ѻ�ͧ��" 
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
                                                ��س��кػ�������áԨ�ͧ��ҹ 
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <table>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA01" runat="server" Text="01 ���᷹��˹���</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Agent" GroupName="PartA"  />
                                                        </td>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA02" runat="server" Text="02 ʶҹ�֡��</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Academy" GroupName="PartA" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA03" runat="server" Text="03 ��Ҥ�</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Association" GroupName="PartA" />
                                                        </td>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA04" runat="server" Text="04 ������� </br> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Chain Store/Wholesaler" GroupName="PartA" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA05" runat="server" Text="05 ��ҧ��þ�Թ���</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Department Store" GroupName="PartA" />
                                                        </td>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA06" runat="server" Text="06 ���Ѵ��˹���</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Distributor" GroupName="PartA" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA07" runat="server" Text="07 ��áԨ�͹�Ź� <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; E-Business" GroupName="PartA" />
                                                        </td>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA08" runat="server" Text="08 ������͡</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Exporter" GroupName="PartA" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA09" runat="server" 
                                                                Text="09 ˹��§ҹ�Ҫ���&lt;/br /&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Government Service" 
                                                                GroupName="PartA" />
                                                        </td>
                                                        <td>
                                                         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                            <ContentTemplate>
                                                            <asp:Checkbox ID="ChkA10" runat="server" Text="10 ��â���(�к�)</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Logistics" GroupName="PartA"  AutoPostBack="true"  OnCheckedChanged="chkA10_CheckedChanged"/>
                                                            <asp:TextBox ID="txtA10" runat="server" Width="140px" Enabled="false"></asp:TextBox>
                                                            </ContentTemplate>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA11" runat="server" Text="11 ����Ե</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Manufacturer" GroupName="PartA" />
                                                        </td>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA12" runat="server" Text="12 ��ͤ�Ң�»�ա</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Retailer" GroupName="PartA" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA13" runat="server" Text="13 ��ҹ��һ�ա</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Retail Outlet" GroupName="PartA" />
                                                        </td>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA14" runat="server" Text="14 �ص��ˡ�����ԡ��</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Service Industry" GroupName="PartA" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA15" runat="server" Text="15 ��ҹ��Ҿ����</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Specialty Store" GroupName="PartA" />
                                                        </td>
                                                        <td>
                                                            <asp:Checkbox ID="ChkA16" runat="server" Text="16 ���͢����й����</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Trading / Importer" GroupName="PartA" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <%--<asp:Checkbox ID="Chk17" runat="server" Text="17 �������</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Wholesaler" GroupName="PartA" />--%>
                                                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:CheckBox ID="ChkA17" runat="server" Text="17 ���� �к�</br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Others"
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
                                                ��ҹ��Һ���ǧҹ��������ҧ��
                                            </td>
                                        </tr>
                                         <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                             <asp:CheckBox ID="ChkB01" runat="server" 
                                                    Text="01 �͡��úѵ��ԭ / �����¨ҡ���Ѵ�ҹ &lt;br/&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Direct mail / Invitation from organizer" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                             <asp:CheckBox ID="ChkB02" runat="server" Text="02 ������ҡ���Ѵ�ҹ <br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email from organizer" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                             <asp:CheckBox ID="ChkB03" runat="server" Text="03 �Թ������ <br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Internet" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                             <asp:CheckBox ID="ChkB04" AutoPostBack="true" 
                                                    OnCheckedChanged="chkB04_CheckedChanged" runat="server" 
                                                    Text="04 ������͹�Ź� ��س����͡&lt;br/&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Social Media. Please tick" /><br />
                                             <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td style="padding-left:20px"><asp:RadioButton ID="rdiChkB04Facebook" AutoPostBack="true" OnCheckedChanged="rdiChkB04Facebook_CheckedChanged" runat="server" Text="Facebook" GroupName="Chk22" /> </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <asp:UpdatePanel ID="upChk22" runat="server">
                                                    <ContentTemplate>
                                                        <tr>
                                                            <td style="padding-left:20px"><asp:RadioButton ID="rdiB04Other" runat="server"  OnCheckedChanged="rdiB04Other_CheckedChanged" Text="���� (��س��к�)<br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Other,please specify" GroupName="Chk22" AutoPostBack="true" /></td>
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
                                                    Text="05 �Ե���� &lt;br/&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Trade Magazine" 
                                                    AutoPostBack="true"  />
                                            <asp:TextBox ID="txtB05" runat="server" Width="240px" Enabled="false"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkB06" runat="server" OnCheckedChanged="chkB06_CheckedChanged" Text="06 ˹ѧ��;���� <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Newspapers" AutoPostBack="true" />
                                            <asp:TextBox ID="txtB06" runat="server" Width="260px" Enabled="false"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkB07" runat="server" Text="07 �����ɳ� <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Street Banners" AutoPostBack="true"  />
                                            </td>
                                        </tr>
                                         <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <asp:CheckBox ID="ChkB08" runat="server" Text="08 �÷�ȹ� /  �Է�� <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  TV / Radio" />
                                            </td>
                                        </tr>
                                         <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <asp:CheckBox ID="ChkB09" runat="server" Text="09 ��������ҹ / ���͹ <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Colleagues / Friends" />
                                            </td>
                                        </tr>
                                         <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <asp:CheckBox ID="ChkB10" runat="server" Text="10 ��Ҥ� / ʶҺѹ <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  Trade Associations / Institutes" />
                                            </td>
                                        </tr>
                                         <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <asp:CheckBox ID="ChkB11" runat="server" Text="11 ����ʴ��Թ��� /  ���Ѵ�ҹ <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  Exhibitors of the Fair" AutoPostBack="true"  />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <asp:CheckBox ID="ChkB12" runat="server" Text="12 ����ص��ˡ�����觻������ <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Invitation From The Federation of Thai Industries"  />
                                             </td>
                                        </tr>
                                         <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <asp:CheckBox ID="ChkB13" runat="server" Text="13 ʶҺѹ����������������ȷҧ෤����� RFID ��觻������ <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Invitation From RFID Institute of Thailand"  />
                                             </td>
                                        </tr>
                                         <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                                <asp:CheckBox ID="ChkB14" runat="server" 
                                                    OnCheckedChanged="chkB14_CheckedChanged" 
                                                    Text="14 ���� &lt;br/&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Others (��س��к�)(Please Specify) " 
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
                                                ��س��к��ѵ�ػ��ʧ��ͧ�����Ҫ��ҹ
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkC01" runat="server" 
                                                    Text="01 �Ң���������ǡѺ෤����� &lt;br/&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Gather Information" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                             <asp:CheckBox ID="ChkC02" runat="server" Text="02 ��ͧ��õԴ��ͼ���� / ����Ե</br> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Establish contact / Visit suppliers" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkC03" runat="server" Text="03 �֡�Ң�����������������ҹ㹤��駵��� <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Evaluate the show for future participation" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkC04" runat="server" Text="04 ��觫����Թ��� <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Place orders" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkC05" runat="server" Text="05 �ҵ��᷹��˹��� <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Seek representatives" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkC06" runat="server" Text="06 ���������觨�˹��� / ��ԡ�� <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Source products / service" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px">
                                            <asp:CheckBox ID="ChkC07" runat="server" Text="07 ����(��س��к�) <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Others(Please specify)" AutoPostBack="true"  OnCheckedChanged="chkC07_CheckedChanged"/>
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
                                                 ��ҹ���ͺ���ѷ�ͧ��ҹ������������ҹ�������á���������
                                            </td>
                                           
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" style="padding-left: 20px" >
                                            <asp:CheckBox ID="ChkD01" runat="server" Text="01 .�� (Yes)"  AutoPostBack="true" OnCheckedChanged="chkD01_CheckedChanged"/>
                                           
                                            
                                            </td>
                                        </tr>
                                        <tr><td  class="Csslbl" style="padding-left: 20px">
                                         <asp:CheckBox ID="ChkD02" runat="server" Text="02 ����� (No) ��س��к�(Please specify)" Wrap="true" AutoPostBack="true"  OnCheckedChanged="chkD02_CheckedChanged"/>
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
                                    ��س��кػ������Թ������ͺ�ԡ�÷���ҹʹ�
                                </td>
                            </tr>
                            <tr>
                                <td class="Csslbl" style="padding-left: 40px">
                                    <table>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE01" runat="server" Text="01 �к������èѴ��ä�ѧ�Թ���<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Warehouse Management System" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE02" runat="server" Text="02 �к������èѴ����ҹ��˹�<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Vehicle Management System" />                                         
                                            </td
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE03" runat="server" Text="03 �к��ѡ�Ҥ�����ʹ���<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Security System" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE04" runat="server" Text="04 �к���Ǩ�ͺ��ü�Ե<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Production Tracking System" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE05" runat="server" Text="05 �к������èѴ����Թ��Ѿ��<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Asset Management System" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE06" runat="server" Text="06 �к���ú�ó����硷�͹ԡ��<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;e-Document System" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE07" runat="server" Text="07 �к���èѴ����ٹ�������/Canteen<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Food Court management System" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE08" runat="server" Text="08 �к������èѴ��ü����������� <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Visitor Management" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" >
                                                <asp:CheckBox ID="ChkE09" runat="server" Text="09 �к������èѴ��þ��ŷ  <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Pallet Management" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" >
                                                <asp:CheckBox ID="ChkE10" runat="server" Text="10 RFID ���͡���֡��<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RFID for Education" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" >
                                                <asp:CheckBox ID="ChkE11" runat="server" Text="11 RFID ���͡�á�����Ф����ѹ�ԧ<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RFID for Sport & Entertainment" />
                                            </td>
                                        </tr>
                                      <%--  <tr>
                                            <td class="Csslbl" >
                                                <asp:CheckBox ID="ChkE12" runat="server" Text="12 �к��Ѵ����Թ��Ҥ���ѧ<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;WMSOne Solutions" />
                                            </td>
                                        </tr>--%>
                                        <tr>
                                            <td class="Csslbl" >
                                                <asp:CheckBox ID="ChkE12" runat="server" Text="12 ෤����պ���Ͷ�� /����� <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Mobile / Tablet Enterprise solutions" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Csslbl" >
                                                <asp:CheckBox ID="ChkE13" runat="server" 
                                                    Text="13 ෤���������ǡѺ��õԴ������˹觴��� GPRS &lt;br/&gt; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;GPS Tracking Solutions" />
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
                                            <asp:CheckBox ID="ChkE14" runat="server" Text="14 �к���÷ӧҹ����ͧẺ�ѵ��ѵ� <br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Automation System" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                             <asp:CheckBox ID="ChkE15" runat="server" Text="15 ෤���������ͧ�����/������ ��� RFID<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Barcode & RFID Printer and Reader" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            <asp:CheckBox ID="ChkE16" runat="server" Text="16 ෤����ա���͡Ẻ��м�Ե RFID<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Design and Manufacture RFID Technology " />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE17" runat="server" 
                                                    Text="17 RFID  ����Ѻ�к��ҹ  �ç��� ,;�����鹷� ,������������ &lt;br /&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RFID  For  Hotel, Apartment, Residential " />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE18" runat="server" 
                                                    Text="18 RFID ����Ѻ�к��ҹ����ǡѺ�آ�Ҿ &lt;/br&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RFID For Healthcare" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="ChkE19" runat="server" 
                                                    Text="19 RFID ����Ѻ�к��ҹ�ѡͺ�մ&lt;/br&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RFID For Laundry&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style2">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style1">
                                                *** �����˵�<br />
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ��س��к���觷��ʹ����ҧ���� 5 �ش �����Ѻ�ҧ���</td>
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

