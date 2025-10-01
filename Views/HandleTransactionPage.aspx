<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="HandleTransactionPage.aspx.cs" Inherits="LOrdCardShop.Views.HandleTransaction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Handle Transactions</h1>
    <br />
    <h3>Unhandled Transactions</h3>
    <asp:GridView ID="UnhandledGV" runat="server" AutoGenerateColumns="False" OnRowEditing="UnhandledGV_RowEditing1">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
            <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
            <asp:ButtonField ButtonType="Button" CommandName="Edit" HeaderText="Handle" ShowHeader="True" Text="Handle" />
        </Columns>

    </asp:GridView>
    <h3>Handled Transactions</h3>
    <asp:GridView ID="HandledGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
            <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
        </Columns>
    </asp:GridView>

</asp:Content>
