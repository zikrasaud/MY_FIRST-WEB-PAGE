<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <tr>
    <td>
    NAME
    </td>
    <td><asp:TextBox ID="txt_name" runat="server"></asp:TextBox></td>
    </tr>

<tr>
    <td>
    FATHERS NAME
    </td>
    <td><asp:TextBox ID="txt_fname" runat="server"></asp:TextBox></td>
    </tr>

    <tr>
    <td>
    ADDRESS
    </td>
    <td><asp:TextBox ID="txt_add" runat="server"></asp:TextBox></td>
    </tr>

    <tr>
    <td>
    MOBILE NO.
    </td>
    <td><asp:TextBox ID="txt_mobile" runat="server"></asp:TextBox></td>
    </tr>

    <tr>
    <td>
    E-MAIL
    </td>
    <td><asp:TextBox ID="txt_email" runat="server"></asp:TextBox></td>
    </tr>

    

    
    <tr>
    <td>
    PASSWORD
    </td>
    <td><asp:TextBox ID="Txt_pwd" runat="server"></asp:TextBox></td>
    </tr>

    <tr>
    <td></td>
    <td>
        <asp:Button ID="btn_sign" runat="server" Text="SIGN UP" 
            onclick="btn_login_Click" /></td></tr>

    </table>
    </div>
    </form>
</body>
</html>
