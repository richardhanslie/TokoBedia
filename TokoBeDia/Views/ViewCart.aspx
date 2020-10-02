<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="TokoBeDia.Views.ViewCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:ButtonField CommandName="Update" Text="Update" ButtonType="Button"></asp:ButtonField>
                <asp:ButtonField CommandName="Delete" Text="Delete" ButtonType="Button"></asp:ButtonField>
            </Columns>
        </asp:GridView>
        <br />
        <div>
            Grand Total : 
            <asp:Label ID="GrandTodal" runat="server"></asp:Label>
        </div>
        <br />
        <asp:Button ID="Checkout" runat="server" Text="Checkout" OnClick="Checkout_Click" />
        <br />
        <asp:Label ID="alert" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
