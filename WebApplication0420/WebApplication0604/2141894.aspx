<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2141894.aspx.cs" Inherits="WebApplication0604._2141894" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .map {
z-index: 1;
left:0;
margin:auto;
background-color: lightblue;
position: absolute;
top: 0;
right:0;
bottom:0;
width: 1052px;
height: 720px;
-moz-border-radius: 10px;
border-radius: 10px;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="pnlMaster" runat="server" CssClass="map" BackColor="#cfd6e5">
                </asp:Panel>
        </div>
    </form>
</body>
</html>
