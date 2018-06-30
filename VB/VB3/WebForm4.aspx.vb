Public Class WebForm4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Response.Write("Hello asp net")
        'ScriptManager.RegisterClientScriptBlock(UpdatePanel1, Me.GetType(), "", "alert('" + TextBox1.Text + "')", True)
        TextBox2.Text = TextBox1.Text

    End Sub


End Class