<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProductType.aspx.cs" Inherits="TokoBeDia.Website.UpdateProductType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         Update Product Type
        <br /><br />
        Product Type :
        <asp:Label ID="oldType" runat="server"></asp:Label>
        <br />
        Description :
        <asp:Label ID="oldDesc" runat="server"></asp:Label>
        <br /><br />
        <div>
            Product Type: 
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            Description: 
            <asp:TextBox ID="descTxt" runat="server"></asp:TextBox>
        </div>
        <br />
            <asp:Label ID="alert" runat="server"></asp:Label>
        <br /><br />
        <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" />
    </div>
    </form>
</body>
</html>
