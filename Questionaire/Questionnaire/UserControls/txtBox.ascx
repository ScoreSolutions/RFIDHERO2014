<%@ Control Language="VB" AutoEventWireup="false" CodeFile="txtBox.ascx.vb" Inherits="UserControls_txtBox" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<link id="MyStyleSheet" href="../Template/StyleSheet.css" rel="stylesheet" type="text/css" />
<asp:TextBox ID="TextBox1" runat="server" EnableTheming="False" CssClass="TextBox"></asp:TextBox>
<asp:Label ID="Label1" runat="server" ForeColor="Red" Text="*"></asp:Label>
<asp:Label ID="lblValidText" runat="server" ForeColor="Red"></asp:Label>
<cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" TargetControlID="TextBox1" runat="server" WatermarkText=" " WatermarkCssClass="CSSWaterMarkText"  >
</cc1:TextBoxWatermarkExtender>