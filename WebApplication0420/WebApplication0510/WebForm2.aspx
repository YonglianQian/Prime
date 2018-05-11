<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication0510.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .error{
            border:3px solid #ff0000;
        }
        .input-area{
            background:#00ffff;

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="input-area" id="divUserName" runat="server">
            <span>Name<sup>*</sup></span>
            <asp:TextBox ID="txtName" runat="server" class="options" placeholder="Name"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
