<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="TokoBeDia.Website.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Email : <asp:Label ID="email" runat="server"></asp:Label>
        <br />
        Name : <asp:Label ID="name" runat="server"></asp:Label>
        <br />
        Gender : <asp:Label ID="gender" runat="server"></asp:Label>
        <br /><br />
        <asp:Button ID="updateProfile" runat="server" Text="Update Profile" OnClick="updateProfile_Click" />
        <br /><br />
        <asp:Button ID="changePassword" runat="server" Text="Change Password" OnClick="changePassword_Click" />
    </div>
    </form>
</body>
</html>
