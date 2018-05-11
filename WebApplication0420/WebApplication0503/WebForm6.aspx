<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication0503.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="rblSourceType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rblSourceType_SelectedIndexChanged">
                <asp:ListItem Value="1">DataSource1</asp:ListItem>
                <asp:ListItem Value="2">DataSource2</asp:ListItem>
            </asp:RadioButtonList>
            <asp:DropDownList ID="ddlSpecSource" runat="server"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        </div>
        <hr style="border:1px solid #ff0000;margin:10px;" />
        <div>
            <asp:Button ID="Copy" runat="server" Text="Copy" OnClick="Copy_Click" /><asp:DropDownList ID="ddlSpecToCopy" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSpecToCopy_SelectedIndexChanged" Visible="False">
                <asp:ListItem Value="1">DataSource1</asp:ListItem>
                <asp:ListItem Value="2">DataSource2</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
