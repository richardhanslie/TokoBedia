<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="TokoBeDia.Website.ViewProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="Update" runat="server"
                        CommandArgument='<%# Bind("ProductId") %>' CommandName="Update" Text="Update"/>
                    <asp:Button ID="Delete_Product" runat="server"
                        CommandArgument='<%# Bind("ProductId") %>' CommandName="Delete_Product" Text="Delete"/>
                </ItemTemplate>                 
                </asp:TemplateField>
            </Columns>     
        </asp:GridView>
        <br />
        <asp:Label ID="alert" runat="server"></asp:Label>
        <br /><br />
        <asp:Button ID="Insert" runat="server" Text="Insert Product" OnClick="Insert_Click" />
        <br /><br />
    </div>
    </form>
</body>
</html>
