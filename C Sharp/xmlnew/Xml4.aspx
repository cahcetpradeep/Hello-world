<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Xml4.aspx.cs" Inherits="Xml4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Button2" />
        <br />
    
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    <br />
    <asp:Label ID="Label2" runat="server"></asp:Label>
    </form>
</body>
</html>
