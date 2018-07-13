Imports System.Data.SqlClient
Imports System.IO

Public Class WebForm7
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            binddata()
        End If

    End Sub

    Public Sub binddata()
        Dim connection As New SqlConnection(ConfigurationManager.ConnectionStrings("MyDataStore").ConnectionString)
        Dim command As New SqlCommand()
        command.CommandText = "select * from Pics"
        command.Connection = connection
        connection.Open()
        Dim sdr As SqlDataReader = command.ExecuteReader()
        Me.GridView1.DataSource = sdr
        Me.GridView1.DataBind()
        connection.Close()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.FileUpload1.HasFile Then
            Dim file As String = FileUpload1.FileName
            Dim ext As String = Path.GetExtension(file)
            Dim name As String = Guid.NewGuid().ToString() & ext

            'save the path to server.
            Dim savepath As String = Server.MapPath("~/Images/") & name
            FileUpload1.SaveAs(savepath)

            ' insert path to database
            Insert("~/Images/" & name)
        End If
        binddata()
    End Sub
    Public Function Insert(ByVal path As String) As Integer
        Dim connection As New SqlConnection(ConfigurationManager.ConnectionStrings("MyDataStore").ConnectionString)
        Dim command As New SqlCommand()
        command.CommandText = "insert into Pics(Path) values('" & path & "')"
        command.Connection = connection
        connection.Open()
        Dim result As Integer = command.ExecuteNonQuery()
        connection.Close()
        Return result
    End Function

    Protected Sub GridView1_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView1.RowCommand
        If e.CommandName = "Download" Then
            Dim file As String = e.CommandArgument.ToString()
            'first way of downloading file.
            'Response.Clear()
            'Response.ContentType = "application/x-zip-compressed"
            'Response.AddHeader("Content-Disposition", "attachment;filename=" + Path.GetFileName(file))
            'Response.TransmitFile(file)

            Dim filename As String = file
            Dim FullFileName As String = Server.MapPath(file)
            Dim fi As New FileInfo(FullFileName)
            If fi.Exists Then
                Response.Clear()
                Response.ClearHeaders()
                Response.Buffer = False
                Response.ContentType = "application/octet-stream"
                Response.AddHeader("Content-Disposition", "attachment;   filename=" & HttpUtility.UrlEncode(fi.FullName, System.Text.Encoding.UTF8))
                Response.AddHeader("Content-Length", fi.Length.ToString())
                Response.WriteFile(fi.FullName)
                Response.Flush()
                Response.End()
            End If
        End If

    End Sub
End Class