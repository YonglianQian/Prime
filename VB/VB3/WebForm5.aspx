<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm5.aspx.vb" Inherits="VB3.WebForm5" %>


<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="System.Data.OleDb" %>
<%@ Import Namespace="System.Web.Configuration" %>
<%@ Import Namespace="System.Diagnostics" %>
<script runat="server">

    Protected Shared idList As New ArrayList()
    Protected Shared Comp As String

    Public NotInheritable Class Utils2
        Private Sub New()
        End Sub

        Public Shared Function GetConnString() As String
            Return WebConfigurationManager.ConnectionStrings("CRAP_HOME_USE_ACCESS").ConnectionString
        End Function

    End Class

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Threading.Thread.Sleep(3000)

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Threading.Thread.Sleep(3000)


    End Sub

    Private Sub Button10_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
</script>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 1446px">

    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server" AsyncPostBackTimeout="0">
            </asp:ScriptManager>

            <p style="font-family: 'Arial Black'; font-size: medium; font-weight: bold; font-style: normal">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Create Access copy for Home use
            </p>
            <asp:Button ID="Button10" runat="server"
                Text="Generate Home Use Database" />
            <asp:Button ID="Button11" runat="server"
                Text="Return to Main" />

            &nbsp;

        <asp:Label ID="Label12" runat="server" Text="Capacitors"></asp:Label>
            &nbsp;
        <asp:Label ID="Label13" runat="server" Text="Connectors"></asp:Label>

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

            <asp:UpdatePanel ID="UpdatePanel2" runat="server" style="width: 750px;" UpdateMode="Conditional">
                <ContentTemplate>
                    <fieldset style="width: 750px;">
                        <asp:Button ID="Button2" runat="server" Text="Export" OnClick="Button2_Click" Style="width: 56px" />
                        &nbsp;              
                <asp:Label ID="Label2" runat="server" Text="Connectors"></asp:Label>
                        &nbsp;
                    <div style="display: inline-block">
                        <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="UpdatePanel2">
                            <ProgressTemplate>
                                <script type="text/javascript">
                                    document.write("<div class='UpdateProgressBackground'></div>");</script>
                                <span class="UpdateProgressContent"
                                    style="background-color: #FFFFFF; font-weight: bold; left: 572px; height: 29px;">Connector export in process...
                            <asp:Image ID="CapWaitCon" runat="server" ImageUrl="~/Images/progress.gif" />
                                </span>
                            </ProgressTemplate>
                        </asp:UpdateProgress>
                    </fieldset>
                </ContentTemplate>

            </asp:UpdatePanel>

            <br />
        </div>
    </form>

    <script type="text/javascript" language="javascript">
    Sys.WebForms.PageRequestManager.getInstance().add_beginRequest(BeginRequestHandler1);
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler1);

    var thebutton;
    var postBackElement;

    function InitializeRequest(sender, args) {

        postBackElement = args.get_postBackElement();
        if (postBackElement.id == 'Button1') {
            $get('UpdateProgress1').style.display = 'block';
        }
        if (postBackElement.id == 'Button2') {
            $get('UpdateProgress2').style.display = 'block';
        }
    }

    function BeginRequestHandler1(sender, args)
    {
        thebutton = args.get_postBackElement();
        if (thebutton.id === "Button1") $get('UpdateProgress1').style.display = 'block';
        if (thebutton.id === "Button2") $get('UpdateProgress2').style.display = 'block';
         thebutton = args.get_postBackElement();
         alert("ID: " + thebutton.id);
         thebutton.disabled = true;
    }

    function EndRequestHandler1(sender, args)
    {
        if (thebutton.id === "Button1") $get('UpdateProgress1').style.display = 'none';
        if (thebutton.id === "Button2") $get('UpdateProgress2').style.display = 'none';
         thebutton.disabled = false;
         var str = thebutton.id;
         if(document.getElementById("Button" + (parseInt(str.substring(6, str.length)) + 1)))
             document.getElementById("Button" + (parseInt(str.substring(6, str.length)) + 1)).click();
    }
    </script>

</body>

</html>
