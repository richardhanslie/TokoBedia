<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="TokoBeDia.Website.ViewUser" %>

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
                    <asp:Button ID="Allow" runat="server"
                        CommandArgument='<%# Bind("id") %>' CommandName="Allow" Text="Allow"/>
                    <asp:Button ID="Block" runat="server"
                        CommandArgument='<%# Bind("id") %>' CommandName="Block" Text="Block"/>
                    <asp:Button ID="Administrator" runat="server"
                        CommandArgument='<%# Bind("id") %>' CommandName="Administrator" Text="Administrator"/>
                    <asp:Button ID="Member" runat="server"
                        CommandArgument='<%# Bind("id") %>' CommandName="Member" Text="Member"/>
                </ItemTemplate>                 
                </asp:TemplateField>
            </Columns>     
        </asp:GridView>
    </div>
    </form>
</body>
</html>
