<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;path :
        <asp:TextBox ID="TextBox1" runat="server" Height="36px" Width="216px"></asp:TextBox>
        <br />
        <br />
&nbsp;
        <asp:Button ID="Button1" runat="server" Height="31px" onclick="Button1_Click" 
            Text="Write" Width="86px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="31px" onclick="Button2_Click" 
            Text="Read" Width="82px" />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
