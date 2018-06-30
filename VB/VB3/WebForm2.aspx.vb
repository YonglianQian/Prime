Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ViewState("sortdirection") = "ASC"
            Session("LastSort") = "Description ASC"
            Session("CurrentIndex") = "Description"
            ReSort()
        End If
    End Sub
    Private Function GetDataSet() As DataSet
        Dim path As String = Server.MapPath("~/App_Data/2.xml")
        Dim ds As DataSet = New DataSet()
        ds.ReadXml(path, XmlReadMode.InferSchema)
        Return ds
    End Function

    Protected Sub DataGridView_Sorting(sender As Object, e As GridViewSortEventArgs) Handles DataGridView.Sorting
        If GetDataSet() IsNot Nothing Then
            Dim dv As DataView = New DataView(GetDataSet().Tables(0))
            If Session("CurrentIndex") <> e.SortExpression Then
                DataGridView.PageIndex = 0
                ViewState("sortdirection") = "ASC"
                Session("CurrentIndex") = e.SortExpression
            Else
                If ViewState("sortdirection").ToString() = "ASC" Then
                    ViewState("sortdirection") = "DESC"
                Else
                    ViewState("sortdirection") = "ASC"
                End If
            End If
            Session("LastSort") = e.SortExpression + " " + ViewState("sortdirection")
            ReSort()
        End If
    End Sub

    Protected Sub DataGridView_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles DataGridView.PageIndexChanging
        DataGridView.PageIndex = e.NewPageIndex
        ReSort()
    End Sub
    Private Sub ReSort()
        If GetDataSet() IsNot Nothing Then
            Dim dv As DataView = New DataView(GetDataSet().Tables(0))
            dv.Sort = Session("LastSort")
            DataGridView.DataSource = dv
            DataGridView.DataBind()
        End If
    End Sub
End Class