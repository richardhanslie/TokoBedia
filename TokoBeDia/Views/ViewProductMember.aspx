<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProductMember.aspx.cs" Inherits="TokoBeDia.Views.ViewProductMember" %>

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
                    <asp:Button ID="AddToCart" runat="server"
                        CommandArgument='<%# Bind("ProductId") %>' CommandName="AddToCart" Text="Add To Cart"/>
                </ItemTemplate>                 
                </asp:TemplateField>
            </Columns>     
        </asp:GridView>
    </div>
    </form>
</body>
</html>
