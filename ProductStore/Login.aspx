<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProductStore.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
         </style>
</head>
<body>
    <form id="LoginForm" runat="server">
       
        <asp:Label ID="lblInvalidUserName" runat="server" Text="UserName" BackColor="White" BorderColor="White" ForeColor="Black"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

        <p><asp:Label ID="lblInvalidPassword" runat="server" Text="Password"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPassword" runat="server"  TextMode="Password"></asp:TextBox></p>

        <p><asp:Label runat="server" ID="lblERROR" ForeColor="Red" Visible="False">Invalid User Name or Password</asp:Label></p>

        <p style="margin-left: 80px"><asp:Button ID="btnLogin" runat="server" OnClick="Button1_Click" Text="Login" BackColor="Black" ForeColor="#66FF33" Height="23px" Width="91px" /></p>
    </form>
</body>
</html>
