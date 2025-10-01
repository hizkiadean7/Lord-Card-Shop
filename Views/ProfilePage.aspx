<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="LOrdCardShop.Views.Profile" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Profile</h1>
    <asp:Label ID="UsernameLbl" runat="server" Text="Username"></asp:Label><br />
    <asp:TextBox ID="UsernameTb" runat="server"></asp:TextBox><br />
    <asp:Label ID="EmailLbl" runat="server" Text="Email"></asp:Label><br />
    <asp:TextBox ID="EmailTb" runat="server"></asp:TextBox><br />

    <asp:Label ID="OldPasswordLbl" runat="server" Text="Old Password"></asp:Label><br />
    <asp:TextBox ID="OldPasswordTb" runat="server"></asp:TextBox><br />
    <asp:Label ID="NewPasswordLbl" runat="server" Text="NewPassword"></asp:Label><br />
    <asp:TextBox ID="NewPasswordTb" runat="server"></asp:TextBox><br />
    <asp:Label ID="ConfirmationPasswordLbl" runat="server" Text="Confirmation Password"></asp:Label><br />
    <asp:TextBox ID="ConfirmationPasswordTb" runat="server"></asp:TextBox><br />

    <asp:Label ID="DOBLbl" runat="server" Text="Date of Birth"></asp:Label><br />
    <asp:TextBox ID="DOBTb" runat="server" TextMode="Date" Text="YYYY-MM-DD" ForeColor="Gray"></asp:TextBox><br />
    <asp:Label ID="GenderLbl" runat="server" Text="Gender"></asp:Label><br />
    <asp:DropDownList ID="GenderDdl" runat="server">
        <asp:ListItem Value="Male">Male</asp:ListItem>
        <asp:ListItem Value="Female">Female</asp:ListItem>
    </asp:DropDownList><br /><br />

    <asp:Button ID="ChangeProfileBtn" runat="server" Text="Change Profile" OnClick="ChangeProfileBtn_Click" />
    <asp:Label ID="ErrorMsg" runat="server" Text=" " ForeColor="Red"></asp:Label><br />
</asp:Content>
