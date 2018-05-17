Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.IO
Imports AjaxControlToolkit

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()>
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WebService2
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function
    <WebMethod()>
    Public Function GetSlides() As AjaxControlToolkit.Slide()
        Dim slides As New List(Of Slide)()
        Dim sPath As String = HttpContext.Current.Server.MapPath("~/ketodocs/")
        If sPath.EndsWith("\") Then
        'sPath = sPath.Remove(sPath.Length - 1)
        End If
        sPath &= "slides\"
        'Dim pathUri As New Uri(sPath, UriKind.Absolute)
        Dim files As String() = Directory.GetFiles(sPath)
        For Each file As String In files
            'Dim filePathUri As New Uri(file, UriKind.Absolute)
            slides.Add(New Slide() With {
              .Name = Path.GetFileNameWithoutExtension(file),
              .Description = Path.GetFileNameWithoutExtension(file) + " Description.",
              .ImagePath = "ketodocs/slides/" + Path.GetFileName(file)
        })
        Next
        Return slides.ToArray()
    End Function


End Class