<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm11.aspx.cs" Inherits="WebApplication0621.WebForm11" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        function Func() {
            $("#ModalPopupExtender2").hide("slow");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
                  <asp:Button ID="btnDummy3" runat="server" Text="btnDummy3"/>
        <cc3:ModalPopupExtender ID="modalPopupExtender1" runat="server"
            CancelControlID="button1"
            OkControlID="button2"
            TargetControlID="btnDummy3"
            PopupControlID="panel1"
            BackgroundCssClass="modalBackground">
        </cc3:ModalPopupExtender>


        <asp:Button ID="btnDummy5" runat="server" Text="btnDummy5"/>
        <cc3:ModalPopupExtender ID="ModalPopupExtender2" runat="server"
            CancelControlID="Button6"
            OnCancelScript="Func();"
            OkControlID="Button4"
            TargetControlID="btnDummy5"
            PopupControlID="panel2"
            BackgroundCssClass="modalBackground">
        </cc3:ModalPopupExtender>


        <asp:UpdatePanel ID="uppnlPreViewPDF" runat="server" ChildrenAsTriggers="true">
            <ContentTemplate>
                <div>
                <asp:Panel ID="Panel1" runat="server" Width="200px" Height="200px" BackColor="Yellow">
                    <div>
                Panel1
                    <asp:Button ID="Button1" runat="server" Text="Cancel" />
                    <asp:Button ID="Button2" runat="server" Text="Ok" />
                    <asp:Button ID="Button5" runat="server" Text="Button" OnClick="Button5_Click" />
                        </div>
                </asp:Panel>
                    </div>
            </ContentTemplate>
        </asp:UpdatePanel>



        <asp:UpdatePanel ID="uppnlHandlePDF" runat="server" ChildrenAsTriggers="true">
            <ContentTemplate>
                <div runat="server" class="container" style="position: relative; z-index: 900001 !important;">
                <asp:Panel ID="panel2" class="form-horizontal" role="form" runat="server" BackColor="#F2F2DC" Width="385px" Height="270px">
                    <div>
                pnlMakeUpPDF
                    <asp:Button ID="Button6" runat="server" Text="Cancel" />
                    <asp:Button ID="Button4" runat="server" Text="OK" />
                        </div>
                </asp:Panel>
                 </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
