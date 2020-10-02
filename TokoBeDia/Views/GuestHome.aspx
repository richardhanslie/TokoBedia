<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuestHome.aspx.cs" Inherits="TokoBeDia.Website.GuestHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Guest Home</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Hi Guest !
        <br /> <br />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <br /> <br />
        <asp:Button ID="ViewProduct" runat="server" Text="View Product" OnClick="ViewProduct_Click" />
        <br /><br />
        <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" />
        <br /> <br />

        <div>
            <asp:Label ID="Label4" runat="server" Text="Don't have account ? "></asp:Label>
            <asp:LinkButton ID="Register" runat="server" OnClick="Register_Click">Register</asp:LinkButton>
        </div>
    </div>
    </form>
</body>
</html>
