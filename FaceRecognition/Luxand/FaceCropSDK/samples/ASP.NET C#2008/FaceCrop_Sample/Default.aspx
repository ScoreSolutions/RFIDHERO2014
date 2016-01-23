<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FaceCrop_Sample._Default"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <h3>Please Upload Photo</h3>
    <form id="form1" enctype="multipart/form-data" runat="server">
        <div>
        File: <input id="myFile" type="file" runat="server" />    
        <input id="Button1" type="button" value="Upload" OnServerClick="Upload" runat="server" />
        <asp:label id="lblMsg" runat="server" />
        <br />
        <asp:image id="Pic" runat="server" />
        <asp:image id="FacePic" runat="server" />
        </div>
    </form>
    
    

    
    
    

</body>
</html>
