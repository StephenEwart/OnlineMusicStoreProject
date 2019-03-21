<%@ Page Title="" Language="C#" MasterPageFile="~/MusicSite.Master" AutoEventWireup="true" CodeBehind="CustomerView.aspx.cs" Inherits="MusicSiteFrontEnd.CustomerView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" style="z-index: 1; left: 381px; top: 318px; position: absolute" Text="View" />
    <asp:ListBox ID="lstCustomers" runat="server" style="z-index: 1; left: 85px; top: 108px; position: absolute; height: 279px; width: 260px; margin-bottom: 0px"></asp:ListBox>
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 313px; top: 77px; position: absolute" Text="Search for a User : "></asp:Label>
    <asp:TextBox ID="txtSearch" runat="server" style="z-index: 1; left: 92px; top: 67px; position: absolute"></asp:TextBox>
    <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" style="z-index: 1; left: 255px; top: 61px; position: absolute" Text="Search" />
</asp:Content>
