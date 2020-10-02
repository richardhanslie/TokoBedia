<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="TokoBeDia.Website.UpdateProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Product</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Update Product
        <br /><br />
        Name : 
        <asp:Label ID="oldName" runat="server"></asp:Label>
        <br />
        Stock :
        <asp:Label ID="oldStock" runat="server"></asp:Label>
        <br />
        Price :
        <asp:Label ID="oldPrice" runat="server"></asp:Label>
        <br />
        Product Type :
        <asp:Label ID="oldType" runat="server"></asp:Label>
        <br /><br />
        <div>
            Name: 
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            Stock: 
            <asp:TextBox ID="stockTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            Price:
            <asp:TextBox ID="priceTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            Product Type ID:
            <asp:TextBox ID="typeTxt" runat="server"></asp:TextBox>
        </div>
        <br />
            <asp:Label ID="alert" runat="server"></asp:Label>
        <br /><br />
        <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" />
    </div>
    </form>
</body>
</html>
