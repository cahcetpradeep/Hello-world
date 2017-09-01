<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatekey.aspx.cs" Inherits="updatekey" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter the Cliend_Id :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="34px" Width="137px"></asp:TextBox>
        <br />
        <br />
        Enter the Country_Name:<asp:TextBox ID="TextBox2" runat="server" Height="31px" 
            Width="138px"></asp:TextBox>
        <br />
        <br />
        Enter User_Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="34px" Width="141px"></asp:TextBox>
        <br />
        <br />
        Enter User_id Value:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="140px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="37px" onclick="Button1_Click" 
            Text="Update" Width="86px" />
    
    </div>
    </form>
</body>
</html>
