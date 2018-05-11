Public Class ContentPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub IbnPeople_Click(sender As Object, e As EventArgs) Handles IbnPeople.Click
        Response.Redirect("/Content/Oops.aspx")
    End Sub

    Private Sub IbnPlaces_Click(sender As Object, e As EventArgs) Handles IbnPlaces.Click
        Response.Redirect("/Content/Oops.aspx")
    End Sub

    Private Sub IbnThings_Click(sender As Object, e As EventArgs) Handles IbnThings.Click
        Response.Redirect("/Content/Oops.aspx")
    End Sub
End Class