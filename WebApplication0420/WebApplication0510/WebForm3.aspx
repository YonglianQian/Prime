<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication0510.WebForm3" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function SessionExpireAlert(timeout) {
            var seconds = timeout / 1000;
            document.getElementsByName("secondsIdle").innerHTML = seconds;
            document.getElementsByName("seconds").innerHTML = seconds;
            setInterval(function () {
                seconds--;
                document.getElementById("seconds").innerHTML = seconds;
                document.getElementById("secondsIdle").innerHTML = seconds;
            }, 1000);
            setTimeout(function () {
                //Show Popup before 20 seconds of timeout.
                $find("mpeTimeout").show();
            }, timeout - 20 * 1000);
            setTimeout(function () {
                window.location.href = "/WebForm5.aspx";
            }, timeout);
            return false;
        };
        function ResetSession() {
            //Redirect to refresh Session.
            window.location = "/WebForm5.aspx";
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <h3 style="font-size: 10px; margin: 0px;">Session Idle:<span id="secondsIdle"></span>seconds.</h3>
        <asp:LinkButton ID="lnkFake" runat="server"/>
        <asp:ModalPopupExtender ID="mpeTimeout" BehaviorID="mpeTimeout" runat="server" 
         PopupControlID="pnlPopup" TargetControlID="lnkFake" OkControlID="btnYes" CancelControlID="btnNo" BackgroundCssClass="modalBackground" OnOkScript="ResetSession()"></asp:ModalPopupExtender>
        <asp:Panel ID="pnlPopup" runat="server" CssClass="modalPopup" Style="text-align: center" BorderColor="#cee2e5" BorderStyle="Solid" BackColor="white" class="header">
            <h4 style="color: white"><b>Session Expiry Alert</b> </h4>
            <asp:Label ID="Label1" runat="server" BackColor="#cee2e5" Font-Bold="True" Text="Session Expiry Alert" Font-Size="Large" ForeColor="DarkBlue" Style="margin-top: 0px" Width="363px" Visible="true"></asp:Label>
            Your Session will expire in<span id="seconds"></span>seconds.
            Do you want to continue?
            <div class="footer">
                <asp:Button ID="btnYes" runat="server" Text="Yes" CssClass="yes" />
                <asp:Button ID="btnNo" runat="server" Text="No" CssClass="no" />
            </div>
        </asp:Panel>
    </form>
</body>
</html>
