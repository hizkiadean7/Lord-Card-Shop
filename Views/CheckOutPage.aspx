<%@ Page Title="Check Out Page" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="CheckOutPage.aspx.cs" Inherits="LOrdCardShop.Views.CheckOutPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Check Out Page</h1>

    <asp:GridView ID="CheckOutGV" runat="server" AutoGenerateColumns="False">
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
    <asp:Label ID="TotalPriceLbl" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="ConfirmCheckOutBtn" runat="server" Text="Confirm checkout" OnClick="ConfirmCheckOutBtn_Click" />
</asp:Content>
