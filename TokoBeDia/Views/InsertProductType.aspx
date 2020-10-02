<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProductType.aspx.cs" Inherits="TokoBeDia.Website.InsertProductType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Insert Product Type
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
        <asp:Button ID="insert" runat="server" Text="Insert" OnClick="insert_Click"/>
    </div>
    </form>
</body>
</html>
