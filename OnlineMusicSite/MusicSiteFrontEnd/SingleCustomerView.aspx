<%@ Page Title="" Language="C#" MasterPageFile="~/MusicSite.Master" AutoEventWireup="true" CodeBehind="SingleCustomerView.aspx.cs" Inherits="MusicSiteFrontEnd.SingleCustomerView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 275px; top: 156px; position: absolute" Text="Email : "></asp:Label>
    <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 274px; top: 189px; position: absolute" Text="Phone No : "></asp:Label>
    <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 298px; top: 91px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 301px; top: 55px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 293px; top: 124px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; left: 293px; top: 160px; position: absolute"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 277px; top: 122px; position: absolute" Text="Username : "></asp:Label>
    <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 274px; top: 88px; position: absolute" Text="Name : "></asp:Label>
    <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" style="z-index: 1; left: 37px; top: 292px; position: absolute" Text="Return" />
</asp:Content>
