<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="DetailTransactionPage.aspx.cs" Inherits="LOrdCardShop.Views.TransactionDetailPage"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Transaction Detail</h2>
    <h3>Transaction Info</h3>
    <asp:GridView ID="DetailGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
            <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate" />
            <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" SortExpression="CustomerID" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
        </Columns>
    </asp:GridView>

    <h3>Card Info</h3>

    <asp:GridView ID="CardGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="CardID" HeaderText="ID" SortExpression="CardID" />
            <asp:BoundField DataField="CardName" HeaderText="Name" SortExpression="CardName" />
            <asp:BoundField DataField="CardPrice" HeaderText="Price" SortExpression="CardPrice" />
            <asp:BoundField DataField="CardDesc" HeaderText="Description" SortExpression="CardDesc" />
            <asp:BoundField DataField="CardType" HeaderText="Type" SortExpression="CardType" />
            <asp:BoundField DataField="isFoil" HeaderText="Foil" SortExpression="isFoil" />
        </Columns>
    </asp:GridView>
</asp:Content>
