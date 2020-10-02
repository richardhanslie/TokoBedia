﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="TokoBeDia.Views.AddToCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            Name : 
            <asp:Label ID="Name" runat="server"></asp:Label>
        </div>
        <div>
            Price : 
            <asp:Label ID="Price" runat="server"></asp:Label>
        </div>
        <div>
            Stock : 
            <asp:Label ID="Stock" runat="server"></asp:Label>
        </div>
        <div>
            Product Type : 
            <asp:Label ID="ProductType" runat="server"></asp:Label>
        </div>
        <div>
            Quantity :  
            <asp:TextBox ID="Quantity" runat="server"></asp:TextBox>
        </div>
        <br />
            <asp:Label ID="alert" runat="server"></asp:Label>
        <br /><br />
        <asp:Button ID="Add" runat="server" Text="Add To Cart" OnClick="Add_Click"/>
    </div>
    </form>
</body>
</html>
