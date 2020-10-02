<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberHome.aspx.cs" Inherits="TokoBeDia.Website.MemberHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Member Home</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Hi <asp:Label ID="name" runat="server"></asp:Label>
        <br /> <br />
        <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="AddToCart" runat="server"
                        CommandArgument='<%# Bind("ProductID") %>' CommandName="AddToCart" Text="Add To Cart"/>
                </ItemTemplate>                 
                </asp:TemplateField>
            </Columns>     
        </asp:GridView>
        <br /> <br />
        <asp:Button ID="ViewProduct" runat="server" Text="View Product" OnClick="ViewProduct_Click" />
        <br /><br />
        <asp:Button ID="ViewProfile" runat="server" Text="View Profile" OnClick="ViewProfile_Click" />
        <br /><br />
        <asp:Button ID="ViewCart" runat="server" Text="View Cart" OnClick="ViewCart_Click" />
        <br /><br />
        <asp:Button ID="ViewTransactionHistory" runat="server" Text="View Transaction History" OnClick="ViewTransactionHistory_Click" />
        <br /><br />
        <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click" />
    </div>
    </form>
</body>
</html>
