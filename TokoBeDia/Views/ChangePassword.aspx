<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="TokoBeDia.Website.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change Password</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Change Password
        <br /><br />
        <div>
            Old Password: 
            <asp:TextBox ID="old" runat="server"></asp:TextBox>
        </div>
        <div>
            New Password: 
            <asp:TextBox ID="newPass" runat="server"></asp:TextBox>
        </div>
        <div>
            Confirm Password: 
            <asp:TextBox ID="confirm" runat="server"></asp:TextBox>
        </div>
        <br />
            <asp:Label ID="alert" runat="server"></asp:Label>
        <br /><br />
        <div>
            <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click"/>
        </div>
    </div>
    </form>
</body>
</html>
