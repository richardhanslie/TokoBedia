<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="TokoBeDia.Views.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Payment Type :
        <br /><br />

        <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="Checkout" runat="server"
                        CommandArgument='<%# Bind("id") %>' CommandName="Checkout" Text="Checkout"/>
                </ItemTemplate>                 
                </asp:TemplateField>
            </Columns>     
        </asp:GridView>
    </div>
    </form>
</body>
</html>
