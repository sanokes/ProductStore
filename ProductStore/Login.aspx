<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProductStore.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="LoginForm" runat="server">
       
        <asp:Label ID="lblInvalidUserName" runat="server" Text="UserName" BackColor="White" BorderColor="White" ForeColor="Black"></asp:Label>
        <br />
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblInvalidPassword" runat="server" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="txtPassword" runat="server"  TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="Loginbtn" align="center" Text="Login"/>
        <br />
        <asp:Label runat="server" ID="lblInvalidCredentials" ForeColor="Red" Visible="False">Invalid User Name or Password</asp:Label>
    </form>
</body>
</html>