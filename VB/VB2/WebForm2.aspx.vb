Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Copy_Click(sender As Object, e As EventArgs) Handles Copy.Click
        ddlSpecToCopy.Visible = True
        ddlSpecToCopy_SelectedIndexChanged(ddlSpecToCopy, New EventArgs())
    End Sub

    Protected Sub ddlSpecToCopy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlSpecToCopy.SelectedIndexChanged
        If ddlSpecToCopy.SelectedValue = "DataSource1" Then
            rblSourceType.SelectedValue = "DataSource1"
        Else
            rblSourceType.SelectedValue = "DataSource2"
        End If
        rblSourceType_SelectedIndexChanged(rblSourceType, New EventArgs())
    End Sub
    Protected Sub rblSourceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rblSourceType.SelectedIndexChanged
        ddlSpecSource.Items.Clear()
        If rblSourceType.SelectedValue = "DataSource1" Then
            SpecSourceData.SelectParameters.Clear()
            SpecSourceData.SelectCommand = "Select * from Products where ID=@Id"
            ddlSpecSource.DataValueField = "ID"
            ddlSpecSource.DataTextField = "Name"
        Else
            SpecSourceData.SelectParameters.Clear()
            SpecSourceData.SelectCommand = "Select * from Persons where Id_P=@Id"
            ddlSpecSource.DataValueField = "Id_P"
            ddlSpecSource.DataTextField = "FirstName"
        End If
        ddlSpecSource.Visible = True

        SpecSourceData.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        SpecSourceData.SelectParameters.Add("Id", 1) ''add esstential parameters to the SpecSourceData
        SpecSourceData.DataBind()
        ddlSpecSource.ClearSelection()
        ddlSpecSource.DataSourceID = "SpecSourceData"
        ddlSpecSource.DataBind()

    End Sub
    Protected Sub ddlSpecSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlSpecSource.SelectedIndexChanged

    End Sub
End Class