<%@ Page Language="C#" MasterPageFile="~/Template/ContentMasterPage.master" AutoEventWireup="true" CodeFile="QuestionnaireForm.aspx.cs" Inherits="Questionnaire_QuestionnaireForm" Title="ข้อมูลแบบสอบถาม" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<%@ Register src="../UserControls/txtBox.ascx" tagname="txtBox" tagprefix="uc1" %>

<%@ Register src="../UserControls/cmbComboBox.ascx" tagname="cmbComboBox" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" width="100%" >
        <tr>
            <td align="center" class="CssHead" >
                <asp:Label ID="lblPageName" runat="server" Text="ข้อมูลแบบสอบถาม"></asp:Label>
                <asp:TextBox ID="txtID" runat="server" Text="0" Visible="false"></asp:TextBox>
            </td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td>
                <table border="0" cellpadding="0" cellspacing="3" width="100%" >
                    <tr>
                        <td width="20%" align="right">ชื่อแบบสอบถาม :&nbsp;</td>
                        <td width="80%" align="left">
                            <uc1:txtBox ID="txtQuestionnaireName" runat="server" Width="650px" />
                            <asp:CheckBox ID="chkActive" runat="server" Checked="true" Text="ใช้งาน" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">วัตถุประสงค์ :&nbsp;</td>
                        <td align="left">
                            <uc1:txtBox ID="txtObjective" runat="server" TextMode="MultiLine" Height="50px" Width="770px" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">คำชี้แจง :&nbsp;</td>
                        <td align="left">
                            <uc1:txtBox ID="txtDesc" runat="server" TextMode="MultiLine" Height="50px" Width="770px" />
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="btnSave" runat="server" Text="บันทึก" Width="80px" OnClick="btnSave_Click" />
                            <asp:Button ID="btnCancel" runat="server" Text="ยกเลิก" Width="80px" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr><td><hr /></td></tr>
        <tr>
            <td align="left" class="CssSubHead" >
                <asp:Label ID="Label1" runat="server" Text="รายละเอียดแบบสอบถาม"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left"  >
                <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Visible="false" 
                    AutoPostBack="true" onactivetabchanged="TabContainer1_ActiveTabChanged" >
                    <asp:TabPanel runat="server" HeaderText="คำถาม" ID="tabQuestion" >
                        <ContentTemplate>
                            <table border="0" cellpadding="0" cellspacing="5" width="100%" align="center" >
                                <tr>
                                    <td align="center" width="50%">
                                        <asp:RoundedCornersExtender ID="RoundedCornersExtender1" runat="server" 
                                        TargetControlID="Panel1" Radius="6" BorderColor="Blue" Enabled="True"  >
                                        </asp:RoundedCornersExtender>
                                        <asp:Panel ID="Panel1" runat="server" width="95%"   >
                                            <table border="0" cellpadding="0" cellspacing="3" width="100%" align="center" >
                                                <tr><td colspan="2">&nbsp;</td></tr>
                                                <tr>
                                                    <td width="25%" align="right" >ส่วนที่ :&nbsp;</td>
                                                    <td width="75%" align="left" >
                                                        <uc2:cmbComboBox ID="cmbSectionID" runat="server" Width="300px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">คำถาม :&nbsp;</td>
                                                    <td align="left">
                                                        <uc1:txtBox ID="txtQuestionName" runat="server" Width="300px" />
                                                        <uc1:txtBox ID="txtQuestionID" runat="server" Visible="False" Text="0" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">ประเภทคำตอบ :&nbsp;</td>
                                                    <td align="left">
                                                        <uc2:cmbComboBox ID="cmbChoiceTypeID" runat="server" Width="300px" AutoPosBack="true" OnSelectedIndexChanged="cmbChoiceTypeID_SelectedIndexChanged" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">คะแนน :&nbsp;</td>
                                                    <td align="left">
                                                        <uc1:txtBox ID="txtPoint" runat="server" Width="30px" TextKey="TextDouble" />
                                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        <asp:CheckBox ID="chkRequire" runat="server" Checked="True" 
                                                            Text="จำเป็นต้องระบุคำตอบ" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>&nbsp;</td>
                                                    <td align="left">
                                                        <asp:Button ID="btnAddQuestion" runat="server" Text="เพิ่ม" Width="80px" OnClick="btnAddQuestion_Click" />
                                                        <asp:Button ID="btnClearQuestion" runat="server" Text="เคลียร์" Width="80px" />
                                                    </td>
                                                </tr>
                                                <tr><td colspan="2">&nbsp;</td></tr>
                                            </table>
                                        </asp:Panel>
                                    </td>
                                    <td align="center" width="50%">
                                        <asp:RoundedCornersExtender ID="RoundedCornersExtender2" runat="server" 
                                        TargetControlID="Panel3" Radius="6" BorderColor="Blue" Enabled="True"  >
                                        </asp:RoundedCornersExtender>
                                        <asp:Panel ID="Panel3" runat="server" width="95%" Height="170px" 
                                            Visible="False"   >
                                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td width="100%" align="left">รายการคำตอบสำหรับ <asp:Label ID="lblChoceTypeText" runat="server"></asp:Label> </td>
                                                </tr>
                                                <tr>
                                                    <td width="100%" align="left">
                                                        <asp:Panel ID="Panel4" runat="server" ScrollBars="Vertical" BorderColor="Black" Height="150px"  >
                                                            <asp:GridView ID="gvChoiceList" runat="server" 
                                                                AutoGenerateColumns="False" CssClass="mGrid" DataKeyNames="id" 
                                                                GridLines="Vertical" PageSize="20" Width="100%">
                                                                <AlternatingRowStyle CssClass="alt" />
                                                                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                                                <PagerSettings Visible="False" />
                                                                <PagerStyle CssClass="pgr" />
                                                                <Columns>
                                                                    <asp:BoundField DataField="id" HeaderText="id" Visible="False" />
                                                                    <asp:BoundField DataField="choice_name" HeaderText="ตัวเลือก" SortExpression="choice_name">
                                                                        <HeaderStyle Width="150px" />
                                                                        <ItemStyle HorizontalAlign="Left" Width="150px" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="point" HeaderText="คะแนน" SortExpression="point">
                                                                        <HeaderStyle Width="50px" />
                                                                        <ItemStyle HorizontalAlign="Right" Width="50px" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="is_default" HeaderText="Default" SortExpression="is_default">
                                                                        <HeaderStyle Width="50px" />
                                                                        <ItemStyle HorizontalAlign="Center" Width="50px" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="is_other" HeaderText="อื่นๆ" SortExpression="is_other">
                                                                        <HeaderStyle Width="50px" />
                                                                        <ItemStyle HorizontalAlign="Center" Width="50px" />
                                                                    </asp:BoundField>
                                                                </Columns>
                                                                
                                                             </asp:GridView>
                                                             <table border="1" cellpadding="0" cellspacing="0" width="100%">
                                                                <tr id="trHead"  runat="server" >
                                                                    <td align="center" runat="server">&nbsp;</td>
                                                                    <td align="center" runat="server">ตัวเลือก</td>
                                                                    <td align="center" runat="server">คะแนน</td>
                                                                    <td align="center" runat="server">ค่าเริ่มต้น</td>
                                                                    <td align="center" runat="server">เพิ่มกล่องข้อความ</td>
                                                                </tr>
                                                                <tr>
                                                                    <td width="50px" align="center">
                                                                        <asp:LinkButton ID="likAddChoice" runat="server" OnClick="likAddChoice_Click" >เพิ่ม</asp:LinkButton>
                                                                        <asp:LinkButton ID="likClearChoice" runat="server" OnClick="likCrearChoice_Click" >ลบ</asp:LinkButton>
                                                                    </td>
                                                                    <td align="left">
                                                                        <uc1:txtBox ID="txtChoiceName" runat="server" Width="150px" />
                                                                    </td>
                                                                    <td width="50px" align="center">
                                                                        <uc1:txtBox ID="txtChoicePoint" runat="server" Width="30px" TextKey="TextDouble" />
                                                                    </td>
                                                                    <td width="50px" align="center">
                                                                        <asp:CheckBox ID="chkChoiceDefault" runat="server" Checked="True" />
                                                                    </td>
                                                                    <td width="80px" align="center">
                                                                        <asp:CheckBox ID="chkChoiceOther" runat="server" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </td>
                                </tr>
                            </table>

                            <asp:GridView ID="gvQuestion" runat="server" AutoGenerateColumns="False" 
                                CssClass="mGrid" DataKeyNames="id" 
                                GridLines="Vertical" PageSize="20" Width="100%">
                                <AlternatingRowStyle CssClass="alt" />
                                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                <PagerSettings Visible="False" />
                                <PagerStyle CssClass="pgr" />
                                <Columns>
                                    <asp:BoundField DataField="id" ShowHeader="False" >
                                        <ControlStyle CssClass="zHidden" />
                                        <FooterStyle CssClass="zHidden" />
                                        <HeaderStyle CssClass="zHidden" />
                                        <ItemStyle CssClass="zHidden" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="questionnaire_section_id" ShowHeader="False" >
                                        <ControlStyle CssClass="zHidden" />
                                        <FooterStyle CssClass="zHidden" />
                                        <HeaderStyle CssClass="zHidden" />
                                        <ItemStyle CssClass="zHidden" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="section_name" HeaderText="ส่วนที่" >
                                    </asp:BoundField>
                                    <asp:BoundField DataField="question_name" HeaderText="คำถาม" >
                                    </asp:BoundField>
                                    <asp:BoundField DataField="choice_type_name" HeaderText="ประเภทคำตอบ" >
                                    </asp:BoundField>
                                    <asp:BoundField DataField="question_point" HeaderText="คะแนน" >
                                    </asp:BoundField>
                                    <asp:BoundField DataField="is_require" HeaderText="Require" >
                                    </asp:BoundField>
                                </Columns>
                            </asp:GridView>
                        </ContentTemplate>
                    </asp:TabPanel>
                    <asp:TabPanel ID="tabSection" runat="server" HeaderText="ส่วนที่">
                        <ContentTemplate>
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr>
                                    <td align="center">
                                        <asp:RoundedCornersExtender ID="RoundedCornersExtender3" runat="server" 
                                        TargetControlID="Panel2" Radius="6" BorderColor="Blue" Enabled="True"  >
                                        </asp:RoundedCornersExtender>
                                        <asp:Panel ID="Panel2" runat="server" width="70%"   >
                                            <table border="0" cellpadding="0" cellspacing="3" width="100%" align="center" >
                                                <tr><td colspan="2">&nbsp;</td></tr>
                                                <tr>
                                                    <td width="25%" align="right" >ชื่อส่วน :&nbsp;</td>
                                                    <td width="75%" align="left" >
                                                        <uc1:txtBox ID="txtSectionName" runat="server" Width="300px" />
                                                        <uc1:txtBox ID="txtQuestionSectionID" runat="server" Visible="False" Text="0" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">คำชี้แจง :&nbsp;</td>
                                                    <td align="left">
                                                        <uc1:txtBox ID="txtSectionDesc" runat="server" Width="300px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">ประเภทแบบสอบถาม :&nbsp;</td>
                                                    <td align="left">
                                                        <uc2:cmbComboBox ID="cmbSectionTypeID" runat="server" Width="300px" AutoPosBack="true" OnSelectedIndexChanged="cmbSectionTypeID_SelectedIndexChanged" />
                                                    </td>
                                                </tr>
                                                <tr id="trChoiceQty" runat="server" visible="false" >
                                                    <td align="right">จำนวนตัวเลือก :&nbsp;</td>
                                                    <td align="left">
                                                        <uc1:txtBox ID="txtChoiceQty" runat="server" Width="30px" TextKey="TextInt" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>&nbsp;</td>
                                                    <td align="left">
                                                        <asp:Button ID="btnAddSection" runat="server" Text="เพิ่ม" Width="80px" OnClick="btnAddSection_Click" />
                                                        <asp:Button ID="btnClearSection" runat="server" Text="เคลียร์" Width="80px" />
                                                    </td>
                                                </tr>
                                                <tr><td colspan="2">&nbsp;</td></tr>
                                            </table>
                                        </asp:Panel>
                                        <asp:GridView ID="gvQuestionnaireSection" runat="server" AutoGenerateColumns="False" 
                                        CssClass="mGrid" DataKeyNames="id" 
                                        GridLines="Vertical" PageSize="20" Width="100%">
                                        <AlternatingRowStyle CssClass="alt" />
                                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                        <PagerSettings Visible="False" />
                                        <PagerStyle CssClass="pgr" />
                                        <Columns>
                                            <asp:BoundField DataField="id" ShowHeader="False" >
                                                <ControlStyle CssClass="zHidden" />
                                                <FooterStyle CssClass="zHidden" />
                                                <HeaderStyle CssClass="zHidden" />
                                                <ItemStyle CssClass="zHidden" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="section_type_id" ShowHeader="False" >
                                                <ControlStyle CssClass="zHidden" />
                                                <FooterStyle CssClass="zHidden" />
                                                <HeaderStyle CssClass="zHidden" />
                                                <ItemStyle CssClass="zHidden" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="section_name" HeaderText="ชื่อส่วน" >
                                                <ItemStyle HorizontalAlign="Left" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="section_type_name" HeaderText="ประเภทแบบสอบถาม" >
                                                <ItemStyle HorizontalAlign="Left" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="description" HeaderText="ประเภทคำตอบ" >
                                                <ItemStyle HorizontalAlign="Left" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="choice_qty" HeaderText="จำนวนตัวเลือก" >
                                            </asp:BoundField>
                                        </Columns>
                                    </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                            
                        </ContentTemplate>
                    </asp:TabPanel>
                </asp:TabContainer>
            </td>
            
        </tr>
    </table>
</asp:Content>

