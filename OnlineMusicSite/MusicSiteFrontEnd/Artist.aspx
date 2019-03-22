<%@ Page Title="" Language="C#" MasterPageFile="~/MusicSite.Master" AutoEventWireup="true" CodeBehind="Artist.aspx.cs" Inherits="MusicSiteFrontEnd.Artist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnDisplay" runat="server" style="z-index: 1; left: 30px; top: 222px; position: absolute" Text="Display All" OnClick="btnDisplay_Click" />
    <asp:ListBox ID="lstArtists" runat="server" style="z-index: 1; left: 27px; top: 75px; position: absolute; height: 141px; width: 255px"></asp:ListBox>
    <asp:TextBox ID="txtSearch" runat="server" style="z-index: 1; left: 30px; top: 42px; position: absolute; width: 187px; height: 18px"></asp:TextBox>
    <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 232px; top: 40px; position: absolute" Text="Find" OnClick="btnFind_Click" />
    </asp:Content>
