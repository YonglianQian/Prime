<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagePhotoAlbum.aspx.cs" Inherits="ListViewAndEF.ManagePhotoAlbum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Manage Photo Album</title>
    <style type="text/css">
        .ItemContainer{
            width: 600px;
            list-style-type:none;
            clear:both;
        }
        .ItemContainer li{
            height:300px;
            width:200px;
            float:left;
        }
        .ItemContainer li img{
            width:180px;
            margin: 10px 20px 10px 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server" DataKeyNames="Id" InsertItemPosition="LastItem"  SelectMethod="ListView1_GetData" InsertMethod="ListView1_InsertItem" DeleteMethod="ListView1_DeleteItem" ItemType="ListViewAndEF.Picture">
                <InsertItemTemplate>
                    <li>
                        Descrition:  <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Text='<%# BindItem.Description%>'></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                        ToolTip: <asp:TextBox ID="TextBox2" runat="server" Text='<%# BindItem.ToolTip%>'></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                        <asp:FileUpload ID="FileUpload1" runat="server" /><br />
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Select a valid jpg" ControlToValidate="FileUpload1"></asp:CustomValidator>
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Insert" CommandName="Insert" />
                    </li>
                </InsertItemTemplate>

                <ItemTemplate>
                    <li>
                        Descrition: <asp:Label ID="Label1" runat="server" Text='<%# Item.Description%>'></asp:Label><br />
                        ToolTip: <asp:Label ID="Label2" runat="server" Text='<%# Item.ToolTip%>'></asp:Label><br />
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Item.ImageUrl %>'/><br />
                        <asp:Button ID="Button2" runat="server" Text="Delete" CommandName="Delete" CausesValidation="false" />
                    </li>
                </ItemTemplate>
                <LayoutTemplate>
                    <ul class="ItemContainer">
                        <li runat="server" id="itemPlaceHolder"></li>
                    </ul>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </form>
</body>
</html>
