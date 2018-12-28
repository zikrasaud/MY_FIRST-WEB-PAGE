<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Start.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <TR><td>
        <asp:Button ID="btn_login" runat="server" Text="LOGIN" Width="81px" 
            onclick="btn_login_Click" /></td></TR>
        <TR><td>
        <asp:Button ID="btn_sign" runat="server" Text="SIGN UP" onclick="btn_sign_Click" /></td></TR>
        </table>
    </div>
    </form>
</body>
</html>
