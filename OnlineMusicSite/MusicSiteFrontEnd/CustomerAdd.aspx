<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerAdd.aspx.cs" Inherits="MusicSiteFrontEnd.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 457px; top: 325px; position: absolute" Text="Confirm" />
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 173px; top: 245px; position: absolute" Text="Phone No : "></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 159px; top: 279px; position: absolute" Text="Card Details : "></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 185px; top: 315px; position: absolute" Text="Address : "></asp:Label>
        <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; left: 264px; top: 243px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCardDetails" runat="server" style="z-index: 1; left: 263px; top: 275px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 266px; top: 312px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 152px; top: 68px; position: absolute" Text="Customer Id : "></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" ReadOnly="True" style="z-index: 1; top: 66px; position: absolute; left: 266px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 266px; top: 100px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 264px; top: 138px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 263px; top: 174px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 130px; top: 103px; position: absolute; right: 714px" Text="Customer Name : "></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 170px; top: 140px; position: absolute" Text="Username : "></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 199px; top: 175px; position: absolute" Text="Email : "></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 173px; top: 209px; position: absolute" Text="Password : "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 263px; top: 207px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
