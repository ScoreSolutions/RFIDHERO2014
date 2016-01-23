<%@ Control Language="VB" AutoEventWireup="false" CodeFile="txtDate.ascx.vb" Inherits="UserControls_txtDate" %>
<link id="MyStyleSheet" href="../Template/StyleSheet.css" rel="stylesheet" type="text/css" />
<asp:TextBox ID="TextBox1" runat="server" AutoPostBack="false" Width="80"  ></asp:TextBox>
<a href="#" onClick="NewCssCal('<%=TextBox1.ClientID %>','DDMMYYYY')" style="text-decoration:none" >
    <img src="../Images/calendarIcon.gif" width="19" height="19" border="0" 
    id="ImageButton1" runat="server" style="vertical-align:baseline;" />
</a>
<asp:Label ID="Label1" runat="server" Text="*" ForeColor="Red"></asp:Label>
<asp:Label ID="lblValidText" runat="server" Text="" ForeColor="Red"></asp:Label>
