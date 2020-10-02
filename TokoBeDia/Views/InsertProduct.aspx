<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="TokoBeDia.Website.InsertProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Product</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Insert Product
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
        <asp:Button ID="insert" runat="server" Text="Insert" OnClick="insert_Click" />
    </div>
    </form>
</body>
</html>
