<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication0621.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="background-color:#ffd800; width: 600px;">
                <tr>
                    <td style="font-weight: bold; width: 80px; border: 1px solid black">ID
                    </td>
                    <td style="font-weight: bold; width: 130px; border: 1px solid black">Name
                    </td>
                    <td style="font-weight: bold; width: 130px; border: 1px solid black">Price
                    </td>
                    <td style="font-weight: bold; width: 260px; border: 1px solid black">Action
                    </td>
                </tr>
            </table>
            <div style="overflow-y: scroll; overflow-x: hidden; height: 200px; width: 600px;">
                <asp:ListView ID="ListView1" runat="server" OnItemCommand="ListView1_ItemCommand" OnItemEditing="ListView1_ItemEditing" OnItemCanceling="ListView1_ItemCanceling">

                    <EditItemTemplate>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Id")%>'></asp:Label></td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Name") %>'></asp:Label></td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("Price") %>'></asp:Label></td>
                            <td>
                                <asp:Button ID="Button3" runat="server" Text="Update" CommandName="Update" />
                                <asp:Button ID="Button2" runat="server" Text="Cancel" CommandName="Cancel" />
                            </td>
                        </tr>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <tr>
                            <td style="width: 80px;">
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Id")%>'></asp:Label></td>
                            <td style="width: 130px;">
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Name") %>'></asp:Label></td>
                            <td style="width: 130px;">
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("Price") %>'></asp:Label></td>
                            <td style="width: 260px;">
                                <asp:Button ID="Button1" runat="server" Text="Edit" CommandName="Edit" />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <table id="groupPlaceholder" border="1" runat="server">
                            <tr id="itemPlaceholder" runat="server"></tr>
                        </table>
                    </LayoutTemplate>
                </asp:ListView>
            </div>
        </div>
    </form>
</body>
</html>
