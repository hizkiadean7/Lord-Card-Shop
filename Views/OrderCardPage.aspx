<%@ Page Title="Order Card Page" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="OrderCardPage.aspx.cs" Inherits="LOrdCardShop.Views.OrderCardPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Order Card Page</h1>
    
    <asp:GridView ID="OrderCardGV" runat="server" AutoGenerateColumns="False" OnRowCommand="OrderCardGV_RowCommand">
        <Columns>
            <asp:BoundField DataField="CardID" HeaderText="ID" SortExpression="CardID" />
            <asp:BoundField DataField="CardName" HeaderText="Name" SortExpression="CardName" />
            <asp:BoundField DataField="CardPrice" HeaderText="Price" SortExpression="CardPrice" />
            <asp:BoundField DataField="CardDesc" HeaderText="Description" SortExpression="CardDesc" />
            <asp:BoundField DataField="CardType" HeaderText="Type" SortExpression="CardType" />
            <asp:BoundField DataField="isFoil" HeaderText="Foil" SortExpression="isFoil" />

            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="QuantityTb" runat="server"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="AddToCartBtn" runat="server" Text="Add To Cart" CommandName="AddToCart" CommandArgument='<%# Container.DataItemIndex %>' />
                    <asp:Button ID="DetailBtn" runat="server" Text="Detail" OnClick="DetailBtn_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="EmptyMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
</asp:Content>
