<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="VB2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="rblSourceType" runat="server" AutoPostBack="True">
                <asp:ListItem>DataSource1</asp:ListItem>
                <asp:ListItem>DataSource2</asp:ListItem>
            </asp:RadioButtonList>
            <asp:DropDownList ID="ddlSpecSource" runat="server" AutoPostBack="True" Visible="False"></asp:DropDownList>
            <asp:SqlDataSource ID="SpecSourceData" runat="server"></asp:SqlDataSource>
            <hr style="border:1px solid #ffd800;margin:10px;" />
            <asp:Button ID="Copy" runat="server" Text="Copy" />
            <asp:DropDownList ID="ddlSpecToCopy" runat="server" AutoPostBack="True" Visible="False">
                <asp:ListItem>DataSource1</asp:ListItem>
                <asp:ListItem>DataSource2</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
