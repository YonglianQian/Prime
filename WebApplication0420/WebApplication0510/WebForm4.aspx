<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication0510.WebForm4" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


            <asp:Panel ID="Panel1" runat="server" Height="167px" Width="190px" BackColor="#d0F7DE">
                <br />
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="137px">
                    <asp:ListItem>看书</asp:ListItem>
                    <asp:ListItem>上网</asp:ListItem>
                    <asp:ListItem>洗衣服</asp:ListItem>
                    <asp:ListItem>出去玩</asp:ListItem>
                </asp:RadioButtonList>
                <asp:Button ID="Button2" runat="server" Text="确定" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" Text="取消" />
            </asp:Panel>
            <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server"
                TargetControlID="Button1"
                PopupControlID="Panel1"
                DropShadow="true"
                OkControlID="Button2"
                CancelControlID="Button3"
                Drag="true"
                BackgroundCssClass="bgcss"
               >
            </cc1:ModalPopupExtender>
            <asp:Panel ID="Panel2" runat="server" Height="83px" Width="187px">
                <asp:Label ID="Label1" runat="server" Text="今天都要做些什么？"></asp:Label><br />
                <asp:Button ID="Button1" runat="server" Text="查看" />
            </asp:Panel>


        </div>
    </form>
</body>
</html>
