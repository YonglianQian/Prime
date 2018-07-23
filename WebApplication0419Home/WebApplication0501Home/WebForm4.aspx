<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication0501Home.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged" Height="17px" Width="249px">
            </asp:DropDownList>
            <br />
            <br />
            Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Surname<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Username<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Password<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            Role<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Update" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="delete" />
        </div>
    </form>
</body>
</html>
