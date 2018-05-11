Public Class Site1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub IbnHelp_Click(sender As Object, e As EventArgs) Handles IbnHelp.Click
        Response.Redirect("/Content/Oops.aspx")
    End Sub

    Protected Sub IbnHome_Click(sender As Object, e As EventArgs) Handles IbnHome.Click
        Response.Redirect("/Content/Home/Default.aspx")
    End Sub
End Class