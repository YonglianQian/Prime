<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm11.aspx.cs" Inherits="WebApplication0510.WebForm11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="NavigationMenu"
                Orientation="Horizontal"
                Target="_blank"
                runat="server">
                <Items>
                    <asp:MenuItem NavigateUrl="Home.aspx"
                        Text="Home"
                        ImageUrl="~/NewFolder1/home.png"
                        ToolTip="Home"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="#"
                        Text="Weather"
                        ImageUrl="~/NewFolder1/nav_02.png"
                        ToolTip="Weather"></asp:MenuItem>
                </Items>
            </asp:Menu>

        </div>
    </form>
</body>
</html>
