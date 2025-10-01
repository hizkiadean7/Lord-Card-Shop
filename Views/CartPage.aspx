<%@ Page Title="Cart Page" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="LOrdCardShop.Views.CartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Cart Page</h1>
    <asp:GridView ID="CartGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="CardID" HeaderText="ID" SortExpression="CardID" />
            <asp:BoundField DataField="CardName" HeaderText="Name" SortExpression="CardName" />
            <asp:BoundField DataField="CardPrice" HeaderText="Price" SortExpression="CardPrice" />
            <asp:BoundField DataField="CardDesc" HeaderText="Description" SortExpression="CardDesc" />
            <asp:BoundField DataField="CardType" HeaderText="Type" SortExpression="CardType" />
            <asp:BoundField DataField="isFoil" HeaderText="Foil" SortExpression="isFoil" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="CheckoutBtn" runat="server" Text="Checkout" OnClick="CheckoutBtn_Click" />
</asp:Content>
