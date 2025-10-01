<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LOrdCardShop.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1>
            <asp:Label ID="UsernameLbl" runat="server" Text="Username"></asp:Label><br />
            <asp:TextBox ID="UsernameTb" runat="server"></asp:TextBox><br />
            <asp:Label ID="PasswordLbl" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="PasswordTb" runat="server"></asp:TextBox><br />
            <asp:CheckBox ID="RememberMeCB" runat="server" Text="Remember Me"/><br />
            <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click"/>
            <asp:Label ID="ErrorMsg" runat="server" Text=" " ForeColor="Red"></asp:Label><br /><br />
            <asp:Label ID="RegisterLbl" runat="server" Text="Don't have an account? "></asp:Label>
            <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click"/>
        </div>
    </form>
</body>
</html>
