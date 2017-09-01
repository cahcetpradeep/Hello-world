<%@ Page Language="C#" AutoEventWireup="true" CodeFile="filterSpecfile.aspx.cs" Inherits="filterSpecfile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp; Enter the path :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="33px" Width="162px"></asp:TextBox>
        <br />
&nbsp;<br />
&nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Filter json Array" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="37px" 
            ontextchanged="TextBox2_TextChanged" Width="166px"></asp:TextBox>
&nbsp;
        <br />
        <br />
    
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
