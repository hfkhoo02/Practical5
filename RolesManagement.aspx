<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RolesManagement.aspx.cs" Inherits="Practical5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Role"></asp:Label>
            <asp:TextBox ID="txtRole" runat="server"></asp:TextBox>
            <asp:Button ID="btnInsertRole" runat="server" Text="Insert Role" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Role List:"></asp:Label>
            <br />
            <asp:ListBox ID="lstRoles" runat="server" AutoPostBack="True"></asp:ListBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="User List:"></asp:Label>
            <br />
            <asp:ListBox ID="lstUsers" runat="server"></asp:ListBox>
            
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Assing Role to User" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Role"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlRole" runat="server">
            </asp:DropDownList>
&nbsp;<asp:Button ID="btnGetRoleUsers" runat="server" Text="Get User" OnClick="btnGetRoleUsers_Click" />
            <br />
            User-Role List:<br />
            <asp:ListBox runat="server" ID="lstUsersRoles"></asp:ListBox>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
