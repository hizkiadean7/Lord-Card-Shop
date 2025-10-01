<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="ManageCardPage.aspx.cs" Inherits="LOrdCardShop.Views.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Card List</h1>
    <asp:GridView ID="CardGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="CardGV_RowDeleting" OnRowEditing="CardGV_RowEditing">
        <Columns>
            <asp:BoundField DataField="CardID" HeaderText="ID" SortExpression="CardID" />
            <asp:BoundField DataField="CardName" HeaderText="Name" SortExpression="CardName" />
            <asp:BoundField DataField="CardPrice" HeaderText="Price" SortExpression="CardPrice" />
            <asp:BoundField DataField="CardDesc" HeaderText="Description" SortExpression="CardDesc" />
            <asp:BoundField DataField="CardType" HeaderText="Type" SortExpression="CardType" />
            <asp:BoundField DataField="isFoil" HeaderText="Foil" SortExpression="isFoil" />
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="UpdateBtn" runat="server" Text="Update" CommandName="Edit"/>
                    <asp:Button ID="DeleteBtn" runat="server" Text="Delete" CommandName="Delete"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="EmptyMsg" runat="server" Text=""></asp:Label><br />
    <asp:Button ID="AddCardBtn" runat="server" Text="Add Card" OnClick="AddCardBtn_Click"/>

</asp:Content>
