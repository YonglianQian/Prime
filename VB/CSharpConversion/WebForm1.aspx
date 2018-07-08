<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CSharpConversion.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<script>

    Protected Shared idList As New ArrayList()
    Protected Shared Comp As String

    Public NotInheritable Class Utils2
        ' sealed to ensure the utility class won't be inherited
        Private Sub New()
        End Sub

        Public Shared Function GetConnString() As String
            Return WebConfigurationManager.ConnectionStrings("CRAP_HOME_USE_ACCESS").ConnectionString
        End Function

    End Class

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Capacitors
        Comp = "Capacitors"

        Dim sqlConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conCString1").ConnectionString)
        Dim ConnString As String = Utils2.GetConnString()
        Dim querystring As String = String.Empty

        querystring = "DELETE * FROM [Capacitors]"
        Using conn As New OleDbConnection(ConnString)
            Using cmd1 As New OleDbCommand(querystring, conn)
                cmd1.CommandType = CommandType.Text
                conn.Open()
                cmd1.ExecuteNonQuery()  'delete capacitors
            End Using
            conn.Close()
        End Using

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection

        ----CODE REMOVED FOR BREVITY----

        Label1.Text = Cap & " Capacitors exported at " & DateTime.Now.ToString()

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Introducing delay for demonstration.
        Comp = "Connectors"
        UpdatePanel2.Update()
        Dim sqlConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("conCString1").ConnectionString)
        Dim ConnString As String = Utils2.GetConnString()

        Dim querystring As String = String.Empty

        querystring = "DELETE * FROM [Connectors]"
        Using conn As New OleDbConnection(ConnString)
            Using cmd1 As New OleDbCommand(querystring, conn)
                cmd1.CommandType = CommandType.Text
                conn.Open()
                cmd1.ExecuteNonQuery()  'delete connectors
            End Using
            conn.Close()
        End Using

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection

        ----CODE REMOVED FOR BREVITY----

        Label2.Text = Con & " Connectors exported at " & DateTime.Now.ToString()    '237 at test

    End Sub

    Private Sub Button10_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
</script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                    </ContentTemplate>
                <Triggers>
                    <%--<asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />--%>
                    <%--<asp:PostBackTrigger ControlID="Button1" />--%>
                </Triggers>
            </asp:UpdatePanel>


        </div>
    </form>
</body>
</html>
