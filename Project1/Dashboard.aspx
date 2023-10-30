<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Project1.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body align="center">
    <form id="form1" runat="server">
        <div>
            <h2>Welcome to the Dashboard!</h2>
            
           <label>TEMPLATES: </label><asp:DropDownList ID="ddlTemplates" runat="server">
               <asp:ListItem Text="select" />
                <asp:ListItem Text="Bank 1" Value="Bank1.json" />
                <asp:ListItem Text="Bank 2" Value="Bank2.json" />
</asp:DropDownList>
            <h1>CSV to GridView Demo</h1>

        <asp:FileUpload ID="fileUpload" runat="server" />
        <asp:Button ID="btnUpload" runat="server" Text="Upload CSV" OnClick="btnUpload_Click" />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
            
        </div>
    </form>

</body>
</html>
