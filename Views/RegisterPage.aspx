<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="LOrdCardShop.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Register</h1>
            <asp:Label ID="UsernameLbl" runat="server" Text="Username"></asp:Label><br />
            <asp:TextBox ID="UsernameTb" runat="server"></asp:TextBox><br />
            <asp:Label ID="EmailLbl" runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="EmailTb" runat="server"></asp:TextBox><br />
            <asp:Label ID="PasswordLbl" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="PasswordTb" runat="server"></asp:TextBox><br />
            <asp:Label ID="ConfirmationPasswordLbl" runat="server" Text="Confirmation Password"></asp:Label><br />
            <asp:TextBox ID="ConfirmationPasswordTb" runat="server"></asp:TextBox><br />
            <asp:Label ID="DOBLbl" runat="server" Text="Date of Birth"></asp:Label><br />
            <asp:TextBox ID="DOBTb" runat="server" TextMode="Date" Text="YYYY-MM-DD" ForeColor="Gray"></asp:TextBox><br />
            <asp:Label ID="GenderLbl" runat="server" Text="Gender"></asp:Label><br />
            <asp:DropDownList ID="GenderDdl" runat="server">
                <asp:ListItem Value="Male">Male</asp:ListItem>
                <asp:ListItem Value="Female">Female</asp:ListItem>
            </asp:DropDownList><br />
            <asp:Label ID="RoleLbl" runat="server" Text="Role"></asp:Label><br />
            <asp:DropDownList ID="RoleDdl" runat="server">
                <asp:ListItem Value="Customer">Customer</asp:ListItem>
                <asp:ListItem Value="Admin">Admin</asp:ListItem>
            </asp:DropDownList><br />            
            <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click"/>
            <asp:Label ID="ErrorMsg" runat="server" Text=" " ForeColor="Red"></asp:Label><br /><br />
            <asp:Label ID="LoginLbl" runat="server" Text="Already have an account? "></asp:Label>
            <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click"/>
        </div>
    </form>
</body>
</html>
