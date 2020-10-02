<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPaymentType.aspx.cs" Inherits="TokoBeDia.Views.InsertPaymentType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Insert Payment Type : 
        <asp:TextBox ID="Type" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="alert" runat="server"></asp:Label>
        <br /><br />
        <asp:Button ID="Insert" runat="server" Text="Insert" OnClick="Insert_Click" />
    </div>
    </form>
</body>
</html>
