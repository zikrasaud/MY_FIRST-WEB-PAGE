﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default2" %>

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
    USERNAME
    </td>
    <td><asp:TextBox ID="Txt_name" runat="server"></asp:TextBox></td>
    </tr>

    <tr>
    <td>
    PASSWORD
    </td>
    <td><asp:TextBox ID="Txt_pwd" runat="server" TextMode="Password" ></asp:TextBox>
    
    </tr>

    <tr>
    <td></td>
    <td>
        <asp:Button ID="btn_login" runat="server" Text="LOGIN" 
            onclick="btn_login_Click" /></td></tr>

    </table>
    </div>
    </form>
</body>
</html>
