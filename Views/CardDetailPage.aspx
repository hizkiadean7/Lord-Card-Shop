<%@ Page Title="Card Detail Page" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="CardDetailPage.aspx.cs" Inherits="LOrdCardShop.Views.CardDetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Card Detail Page</h1>
    
    <asp:Label ID="Label1" runat="server" Text="Card Detail Page"></asp:Label>
    <asp:GridView ID="CardDetailGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="CardName" HeaderText="Name" SortExpression="CardName" />
            <asp:BoundField DataField="CardPrice" HeaderText="Price" SortExpression="CardPrice" />
            <asp:BoundField DataField="CardType" HeaderText="Type" SortExpression="CardType" />
            <asp:BoundField DataField="CardDesc" HeaderText="Description" SortExpression="CardDesc" />
        </Columns>
    </asp:GridView>
    
    <asp:Button ID="BackBtn" runat="server" Text="Back" OnClick="BackBtn_Click" />
</asp:Content>
