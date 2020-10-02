<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactionHistoryMember.aspx.cs" Inherits="TokoBeDia.Views.ViewTransactionHistoryMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Transaction History
        <br /><br />
         <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="Detail" runat="server"
                        CommandArgument='<%# Bind("id") %>' CommandName="Detail" Text="Detail"/>
                </ItemTemplate>                 
                </asp:TemplateField>
            </Columns>     
        </asp:GridView>
    </div>
    </form>
</body>
</html>
