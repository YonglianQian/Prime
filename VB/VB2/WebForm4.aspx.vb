Public Class WebForm4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub




    <System.Web.Services.WebMethod()>
    <System.Web.Script.Services.ScriptMethod()>
    Public Shared Function GetSlides1() As AjaxControlToolkit.Slide()
        Return New AjaxControlToolkit.Slide() {
        New AjaxControlToolkit.Slide("ketodocs/1.jpg", "图片01的标题", "图片01的说明"),
        New AjaxControlToolkit.Slide("ketodocs/2.jpg", "图片02的标题", "图片02的说明"),
        New AjaxControlToolkit.Slide("ketodocs/3.jpg", "图片03的标题", "图片03的说明")}
    End Function

End Class