<%@ Control Language="VB" AutoEventWireup="false" CodeFile="cmbAutoComplete.ascx.vb" Inherits="UserControls_cmbAutoComplete" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<link id="MyStyleSheet" href="../Template/StyleSheet.css" rel="stylesheet" type="text/css" />
<cc1:ComboBox ID="cmbCombo" runat="server" 
     DropDownStyle="DropDownList" CausesValidation="true"
     AutoCompleteMode="Suggest" 
     CaseSensitive="False" 
     CssClass=""
     ItemInsertLocation="OrdinalValue" ></cc1:ComboBox>
<asp:Label ID="lblValidText" runat="server" ForeColor="Red" ></asp:Label>