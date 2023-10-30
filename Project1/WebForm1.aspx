<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Project1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body align="center">
    <form id="form1" runat="server" >
        <div>
    <h2>Login</h2>
    <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <label>USERNAME:</label><asp:TextBox ID="txtUsername" runat="server" Placeholder="Username"></asp:TextBox>
    <br />
    <label>PASSWORD:</label><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Password"></asp:TextBox>
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>

</body>
</html>
