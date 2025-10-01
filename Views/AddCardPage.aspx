<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="AddCardPage.aspx.cs" Inherits="LOrdCardShop.Views.AddCardPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Add Card</h1>
    <asp:Label ID="NameLbl" runat="server" Text="Name"></asp:Label><br />
    <asp:TextBox ID="NameTb" runat="server"></asp:TextBox><br />
    <asp:Label ID="PriceLbl" runat="server" Text="Price"></asp:Label><br />
    <asp:TextBox ID="PriceTb" runat="server"></asp:TextBox><br />
    <asp:Label ID="DescriptionLbl" runat="server" Text="Description"></asp:Label><br />
    <asp:TextBox ID="DescriptionTb" runat="server"></asp:TextBox><br />
        <asp:Label ID="TypeLbl" runat="server" Text="Type"></asp:Label><br />
    <asp:TextBox ID="TypeTb" runat="server"></asp:TextBox><br />
        <asp:Label ID="FoilLbl" runat="server" Text="Foil"></asp:Label><br />
    <asp:DropDownList ID="FoilDdl" runat="server">
        <asp:ListItem Value="True">Yes</asp:ListItem>
        <asp:ListItem Value="False">No</asp:ListItem>
    </asp:DropDownList><br /><br />
    <asp:Button ID="AddBtn" runat="server" Text="Add Card" OnClick="AddBtn_Click"/>
    <asp:Label ID="ErrorMsg" runat="server" Text=" " ForeColor="Red"></asp:Label>
</asp:Content>
