Public Class WebForm6
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If True Then

        End If
    End Sub






    Private Sub GridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridView1.RowDataBound
        Dim drv As DataRowView
        drv = e.Row.DataItem
        If Not (IsNothing(drv)) Then
            ListBox1.Items.Add(drv("Name").ToString())
        End If


    End Sub


End Class