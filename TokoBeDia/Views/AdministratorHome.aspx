<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdministratorHome.aspx.cs" Inherits="TokoBeDia.Website.AdministratorHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administrator Home</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Hi <asp:Label ID="name" runat="server"></asp:Label>
        <br /><br />
        <asp:Button ID="ViewUser" runat="server" Text="View User" OnClick="ViewUser_Click" />
        <br /><br />
        <asp:Button ID="ViewProduct" runat="server" Text="View Product" OnClick="ViewProduct_Click" />
        <br /><br />
        <asp:Button ID="InsertProduct" runat="server" Text="Insert Product" OnClick="InsertProduct_Click" />
        <br /><br />
        <asp:Button ID="ViewProductType" runat="server" Text="View Product Type" OnClick="ViewProductType_Click" />
        <br /><br />
        <asp:Button ID="InsertProductType" runat="server" Text="Insert Product Type" OnClick="InsertProductType_Click" />
        <br /><br />
        <asp:Button ID="ViewPaymentType" runat="server" Text="View Payment Type" OnClick="ViewPaymentType_Click"/>
        <br /><br />
        <asp:Button ID="InsertPaymentType" runat="server" Text="Insert Payment Type" OnClick="InsertPaymentType_Click" />
        <br /><br />
         <asp:Button ID="ViewTransactionHistory" runat="server" Text="View Transaction History" OnClick="ViewTransactionHistory_Click"/>
        <br /><br />
        <asp:Button ID="ViewProfile" runat="server" Text="View Profile" OnClick="ViewProfile_Click" />
        <br /><br />
        <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click" />
    </div>
    </form>
</body>
</html>
