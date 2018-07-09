<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm6.aspx.vb" Inherits="VB3.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        window.onload = function () {
            document.getElementById("Button1").click();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" style="width: 750px;" UpdateMode="Conditional">
                <ContentTemplate>
                    <fieldset style="width: 750px;">
                        <asp:Button ID="Button1" runat="server" Text="Export" OnClick="Button1_Click" Style="width: 56px" />
                        &nbsp;        
                <asp:Label ID="Label1" runat="server" Text="Capacitors"></asp:Label>
                        &nbsp;
                    <div style="display: inline-block">
                        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                            <ProgressTemplate>
                                <script type="text/javascript">
                                    document.write("<div class='UpdateProgressBackground'></div>");</script>
                                <span class="UpdateProgressContent"
                                    style="background-color: #FFFFFF; font-weight: bold; left: 572px; height: 29px;">Capacitor export in process...
                            <asp:Image ID="CapWaitCap" runat="server" ImageUrl="~/Images/progress.gif" />
                                </span>
                            </ProgressTemplate>
                        </asp:UpdateProgress>
                    </div>
                    </fieldset>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
