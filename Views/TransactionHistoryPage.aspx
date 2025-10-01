<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="LOrdCardShop.Views.TransactionHistoryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Transaction History</h2>
    <asp:GridView ID="TransactionGV" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="TransactionGV_SelectedIndexChanging">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="ID" SortExpression="TransactionID" />
            <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Detail" Text="Detail" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="EmptyMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
</asp:Content>
