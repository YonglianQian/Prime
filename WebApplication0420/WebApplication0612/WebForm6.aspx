<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication0612.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
                    ID:<asp:Label ID="Label1" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                    <asp:Image ID="Image2" runat="server" ImageUrl='<%# Handle(Eval("ImageUrl")) %>' Width="50px" Height="50px"/>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
