<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="MusicSiteFrontEnd.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomers" runat="server" style="z-index: 1; left: 235px; top: 83px; position: absolute; height: 219px; width: 255px"></asp:ListBox>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 449px; top: 320px; position: absolute" Text="Edit" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 236px; top: 323px; position: absolute" Text="Add" />
        <asp:Button ID="btnSearch" runat="server" style="z-index: 1; left: 431px; top: 44px; position: absolute" Text="Search" />
        <asp:TextBox ID="txtSearch" runat="server" style="z-index: 1; left: 240px; top: 45px; position: absolute; width: 174px"></asp:TextBox>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 335px; top: 322px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
