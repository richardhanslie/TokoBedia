<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePaymentType.aspx.cs" Inherits="TokoBeDia.Views.UpdatePaymentType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Type :
        <asp:Label ID="oldType" runat="server"></asp:Label>
        <br /><br />
        Update Payment Type : 
        <asp:TextBox ID="Type" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="alert" runat="server"></asp:Label>
        <br /><br />
        <asp:Button ID="Update" runat="server" Text="Update" OnClick="Update_Click"/>
    </div>
    </form>
</body>
</html>
