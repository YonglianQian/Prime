<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ListViewAndEF.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .ItemContainer ul li {
            width: 160px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>

                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" SelectMethod="PhotoAlbumList_GetData" DataTextField="Name" DataValueField="Id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                    <asp:ListView ID="ListView1" runat="server" DataKeyNames="Id" ItemType="ListViewAndEF.Picture" SelectMethod="ListView1_GetData">
                        <EmptyDataTemplate>
                            There is no Data here
                        </EmptyDataTemplate>
                        <ItemTemplate>
                            <li>
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Item.ImageUrl %>' ToolTip='<%# Item.ToolTip %>' />
                                <asp:Label Text='<%# Item.Description %>' ID="label1" runat="server" />
                            </li>
                        </ItemTemplate>
                        <LayoutTemplate>
                            <ul class="ItemContainer">
                                <li id="itemPlaceholder" runat="server"></li>
                            </ul>
                            <div style="clear: both;">
                            </div>
                        </LayoutTemplate>
                    </asp:ListView>
                    <asp:DataPager ID="DataPager1" runat="server" PageSize="1" PagedControlID="ListView1">
                        <Fields>
                            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowLastPageButton="true" />
                        </Fields>
                    </asp:DataPager>
                </ContentTemplate>
            </asp:UpdatePanel>


        </div>
    </form>
</body>
</html>
