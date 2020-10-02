<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TokoBeDia.Website.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            Email: 
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            Name: 
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            Password:
            <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            Confirm Password:
            <asp:TextBox ID="confirmPasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:RadioButton ID="Male" runat="server" GroupName="gender" Text="Male"/>
            <asp:RadioButton ID="Female" runat="server" GroupName="gender" Text="Female"/>
        </div>
        <br />
            <asp:Label ID="alert" runat="server"></asp:Label>
        <br /><br />
        <div>
            <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
        </div>

    </div>
    </form>
</body>
</html>
