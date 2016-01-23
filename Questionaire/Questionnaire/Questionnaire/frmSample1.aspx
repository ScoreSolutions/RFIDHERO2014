<%@ Page Language="C#" MasterPageFile="~/Template/ContentMasterPage.master" AutoEventWireup="true" CodeFile="frmSample1.aspx.cs" Inherits="Questionnaire_frmSample1" Title="แบบสอบถาม" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" width="100%" >
        <tr>
            <td align="center" class="CssHead" >
                <asp:Label ID="lblQusitionnaireName" runat="server" Text="ตัวอย่างแบบสอบถาม"></asp:Label>
                <asp:TextBox ID="txtID" runat="server" Text="0" Visible="false"></asp:TextBox>
            </td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td>
                <b>วัตถุประสงค์ : </b>
                <asp:Label ID="lblQuestionnaireObjective" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>คำชี้แจง : </b>
                <asp:Label ID="lblQuestionnaireDesc" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td>
                <asp:GridView ID="gvSection" runat="server" AutoGenerateColumns="false" 
                    OnRowDataBound="gvSection_RowDataBound"  >
                    <Columns>
                        <asp:BoundField DataField="id" ShowHeader="false" >
                            <ControlStyle CssClass="zHidden" />
                            <FooterStyle CssClass="zHidden" />
                            <HeaderStyle CssClass="zHidden" />
                            <ItemStyle CssClass="zHidden" />
                        </asp:BoundField>
                        <asp:TemplateField ShowHeader="false" >
                            <HeaderStyle Width="100%" HorizontalAlign="Center" CssClass="zHidden" />
                            <ItemStyle Width="100%" HorizontalAlign="Left" />
                            <ItemTemplate >
                                <asp:Label ID="lblSection" runat="server" Text="<%# Bind('section_name') %>"  ></asp:Label>
                                
                                <asp:GridView ID="gvQuestion" runat="server" AutoGenerateColumns="false"
                                 OnRowDataBound="gvQuestion_RowDataBound" BorderStyle="None" >
                                    <Columns>
                                        <asp:BoundField DataField="id" ShowHeader="false" >
                                            <ControlStyle CssClass="zHidden" />
                                            <FooterStyle CssClass="zHidden" />
                                            <HeaderStyle CssClass="zHidden" />
                                            <ItemStyle CssClass="zHidden" />
                                        </asp:BoundField>
                                        <asp:TemplateField ShowHeader="false" >
                                            <HeaderStyle CssClass="zHidden" Width="30px" />
                                            <ItemStyle Width="30px" />
                                            <ItemTemplate >
                                                <asp:Label ID="lblChoiceTypeID" runat="server" Text="<%# Bind('choice_type_id') %>" Visible="false" ></asp:Label>&nbsp;
                                                <asp:Label ID="lblQuestionPoint" runat="server" Text="<%# Bind('question_point') %>"  Visible="false" ></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField >
                                        <asp:TemplateField ShowHeader="false" >
                                            <HeaderStyle Width="600px" HorizontalAlign="Center" CssClass="zHidden" />
                                            <ItemStyle Width="600px" HorizontalAlign="Left" />
                                            <ItemTemplate >
                                                <asp:Label ID="lblNo" runat="server" Text="<%# Bind('no') %>"  ></asp:Label>&nbsp;
                                                <asp:Label ID="lblQuestionName" runat="server" Text="<%# Bind('question_name') %>"  ></asp:Label>
                                                <asp:Label ID="lblRequire" ForeColor="Red" runat="server" Text='<%# Eval("is_require").ToString() == "Y" ? "*" : "" %>'  ></asp:Label>
                                                <asp:Label ID="lblBR" runat="server" ></asp:Label>
                                                <asp:TextBox ID="txtChoice" runat="server" Visible="false"></asp:TextBox>
                                                <asp:Label ID="lblTextChoiceName" runat="server" Visible="false" ></asp:Label>
                                                
                                                
                                                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                    <tr>
                                                        <td width="50px">&nbsp;</td>
                                                        <td>
                                                            <asp:RadioButtonList ID="rdiChoice" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" Visible="false"
                                                             OnSelectedIndexChanged="rdiChoice_SelectedIndexChanged" >
                                                            </asp:RadioButtonList>
                                                            <asp:TextBox ID="txtRadioChoice" runat="server" Visible="false" Enabled="false"></asp:TextBox>
                                                            
                                                            <asp:CheckBoxList ID="chkChoice" runat="server" Visible="false" RepeatLayout="Flow"
                                                             OnSelectedIndexChanged="chkChoice_SelectedIndexChanged" >
                                                            </asp:CheckBoxList>
                                                            <asp:TextBox ID="txtCheckBoxChoice" runat="server" Visible="false" Enabled="false"></asp:TextBox>
                                                            
                                                            <asp:DropDownList ID="ddlChoice" runat="server" Visible="false" >
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField ShowHeader="false" >
                                            <HeaderStyle Width="400px" HorizontalAlign="Center" CssClass="zHidden" />
                                            <ItemStyle Width="400px" HorizontalAlign="Left" />
                                            <ItemTemplate >
                                                <asp:RadioButtonList ID="rdiSec2Choice" runat="server" RepeatDirection="Horizontal" RepeatLayout="Table" Visible="false" >
                                                </asp:RadioButtonList>
                                                
                                                <asp:CheckBoxList ID="chkSec2Choice" runat="server" Visible="false" >
                                                </asp:CheckBoxList>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td align="center">
                <asp:Button ID="btnSave" runat="server" Text="ส่งข้อมูล" CssClass="CssBtn" Width="80px" OnClick="btnSave_Click" />
                <asp:Label ID="lblText" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

