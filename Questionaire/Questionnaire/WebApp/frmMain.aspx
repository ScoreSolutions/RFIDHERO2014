<%@ Page Language="C#" MasterPageFile="~/Template/ContentMasterPage.master" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="WebApp_frmMain" Title="Untitled Page"  EnableEventValidation="false"%>
<%@ Register src="../UserControls/txtBox.ascx" tagname="txtBox" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            color: #000000;
            text-decoration: none;
            vertical-align: top;
            font-style: normal;
            font-variant: normal;
            font-size: 12px;
            line-height: normal;
            font-family: Arial, "Courier New", Courier, monospace;
            width: 68px;
            padding: 1px;
        }
        .style2
        {
            width: 325px;
        }
    </style>
   <%-- <script type="text/javascript">
        function show() {
            document.getElementById("<%=divLogin.ClientID%>").style.display = "block";
            document.getElementById("<%=div1.ClientID%>").style.display = "none";
        }
    </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    
      
    <div id="div1" runat="server">
       
        
       
    
<table width="100%">
       
     
    <tr>
        <td colspan="2" align="center">
            <h2>
        ท่านเคยเข้าร่วมงาน RFID Hero 2013 หรือไม่
            </h2>
        </td>
    </tr>
    <tr>
        <td colspan="2" align="center">
            <h2>
        Have you ever attended RFID Hero 2013 or not.
            </h2>
        </td>
    </tr>
    
    <tr>
        <td align="right">
        <%-- <input type="button" value="Yes"  onclick="show();" 
                style="font-size: medium; width: 60px" />--%>
             <asp:Button ID="btnYes" runat="server" Text="Yes" 
                     Width="60px" onclick="btnYes_Click" />     
            
        </td>
        <td align="left">
            <%--<input type="button" value="No"  style="font-size: medium; width: 60px" onclick="window.location.href='frmRegister2.aspx'; return false;" />--%>
             <asp:Button ID="btnNo" runat="server" Text="No" 
                     Width="60px" onclick="btnNo_Click" /> 
            
        </td>
    </tr>
</table>
</div>

<div id="divLogin" style="display: none;"  runat="server">
    <table border="0" cellpadding="0" cellspacing="0" width="100%" >
        <tr align="center">
            <td colspan="6"> 
                <h2>
                กรุณากรอก อีเมล์ หรือ หมายเลขโทรศัพท์มือถือ เพื่อรับรหัสลงทะเบียน
                </h2>
            </td>
        </tr>
        <tr align="center">
            <td colspan="6">
                <h2>
                Please enter your email or mobile number. To receive a registration code
                </h2>
            </td>
        </tr>
      
       
    
        <tr>
            <td class="style1" align="right">
                &nbsp;</td>
            <td class="Csslbl" align="right">
                &nbsp;</td>
            <td  align="left" style="padding-left: 10px">
                &nbsp;</td>
            <td class="Csslbl" align="right">
                &nbsp;</td>
            <td  align="left" style="padding-left: 10px" class="style2">
                &nbsp;</td>
            <td  align="left" style="padding-left: 10px">
                &nbsp;</td>
        </tr>
       
    
        <tr>
            <td class="style1" align="right">
                &nbsp;</td>
            <td class="Csslbl" align="right">
                อีเมล์ :<br />E-mail
            </td>
            <td  align="left" style="padding-left: 10px">
                <uc1:txtBox ID="txtEmail" runat="server" Width="200px" MaxLength="255" />
                &nbsp;&nbsp;
            </td>
            <td class="Csslbl" align="right">
                โทรศัพท์มือถือ  :<br />Mobile
            </td>
            <td  align="left" style="padding-left: 10px" class="style2">
                <uc1:txtBox ID="txtMobileNo" runat="server" Width="200px" MaxLength="10" TextKey="TextInt"/>
                &nbsp;&nbsp;
            </td>
            <td  align="left" style="padding-left: 10px">
                &nbsp;</td>
        </tr>
       
        <tr>
            <td class="style1" align="right">
                &nbsp;</td>
            <td class="Csslbl" align="right">
                &nbsp;</td>
            <td  align="left" style="padding-left: 10px">
                &nbsp;</td>
            <td class="Csslbl" align="right">
                &nbsp;</td>
            <td  align="left" style="padding-left: 10px" class="style2">
                &nbsp;</td>
            <td>
            </td>
            <td  align="left" style="padding-left: 10px">
                &nbsp;</td>
        </tr>
       
        <tr>
            <td class="style1" align="center">
                &nbsp;</td>
            <td class="Csslbl" align="center" colspan="4">
                <asp:Button ID="btnOK" runat="server" Text="OK" onclick="btnOK_Click" 
                    Width="60px" />
                &nbsp;
                <asp:Button ID="btnCancel" runat="server" Text="Register New" 
                    onclick="btnCancel_Click" Width="100px" />
            </td>
            <td class="Csslbl" align="center">
                &nbsp;</td>
        </tr>
        
          <tr align="center">   
            <td colspan="6" align="center">
                <asp:Label ID="lblerror" runat="server" ForeColor="Red"></asp:Label>
            </td>
           
        </tr>
        
    </table>
   
    </div>
   
</asp:Content>

