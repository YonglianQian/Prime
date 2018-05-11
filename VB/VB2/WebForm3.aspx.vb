Public Class WebForm3
    Inherits System.Web.UI.Page

    Dim lngCopySpecID As Long = 0
    Dim lngCopySrcID As Long = 0
    Dim strCopySpecNmbr As String


    Protected Sub btnNewSpecFromCopy_Click(sender As Object, e As EventArgs) Handles btnNewSpecFromCopy.Click

        If IsPostBack Then
            InitializeLoadSpec()
        End If

        lblCstmrOrStndrd.Visible = True
        rblCstmrOrStndrd.Visible = True

    End Sub

    Protected Sub rblCstmrOrStndrd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rblCstmrOrStndrd.SelectedIndexChanged

        If rblCstmrOrStndrd.SelectedValue = 1 Then
            CopyFromSrcData.SelectCommand = "SELECT CustomerID AS SlctdSrcID, Customer FROM LUCustomers WHERE (IsCurrent = @IsCurrent) ORDER BY Customer;"
            ddlCopyFromSrc.DataValueField = "SlctdSrcID"
            ddlCopyFromSrc.DataTextField = "Customer"
            lblCopyFromSrc.Text = "Customer"
        ElseIf rblCstmrOrStndrd.SelectedValue = 2 Then
            CopyFromSrcData.SelectCommand = "SELECT StandardsOrgID AS SlctdSrcID, RTrim(StandardsOrgCode) + ' - ' 
   + RTrim(StandardsOrganization) AS StndrdOrg
                                            FROM LUStandardsOrganizations WHERE (IsCurrent = @IsCurrent)
                                            ORDER BY RTrim(StandardsOrgCode) + ' - ' + RTrim(StandardsOrganization);"
            ddlCopyFromSrc.DataValueField = "SlctdSrcID"
            ddlCopyFromSrc.DataTextField = "StndrdOrg"
            lblCopyFromSrc.Text = "Standards Organization"
        End If

        ddlCopyFromSrc.Visible = True
        lblCopyFromSrc.Visible = True

        CopyFromSrcData.DataBind()
        ddlCopyFromSrc.DataBind()

        If rblCstmrOrStndrd.SelectedValue = 1 Then
            ddlCopyFromSrc.Items.Insert(0, New ListItem("- Choose Customer", "-1"))
        ElseIf rblCstmrOrStndrd.SelectedValue = 2 Then
            ddlCopyFromSrc.Items.Insert(0, New ListItem("- Choose Standards Organization", "-1"))
        End If

    End Sub

    Protected Sub ddlCopyFromSrc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCopyFromSrc.SelectedIndexChanged

        If rblCstmrOrStndrd.SelectedValue = 1 Then
            SpecToCopyData.SelectCommand = "SELECT DISTINCT Specifications.SpecID, RTrim(Specifications.SpecNmbr) 
                                           + ' Rev ' + RTrim(Specifications.SpecRev) AS Spec FROM Specifications 
                                           LEFT JOIN SpecToCustomer ON Specifications.SpecID = SpecToCustomer.SpecID 
                                           WHERE (SpecToCustomer.CustomerID = @SlctdSrcID) 
                                           ORDER BY RTrim(Specifications.SpecNmbr) + ' Rev ' + RTrim(Specifications.SpecRev);"
        ElseIf rblCstmrOrStndrd.SelectedValue = 2 Then
            SpecToCopyData.SelectCommand = "SELECT DISTINCT SpecID, RTrim(SpecNmbr) 
                                            + ' Rev ' + RTrim(SpecRev) AS Spec FROM Specifications  
                                            WHERE (StandardsOrgID = @SlctdSrcID)
                                            ORDER BY RTrim(SpecNmbr) + ' Rev ' + RTrim(SpecRev);"
        End If

        ddlSpecToCopy.Visible = True
        lblSpecToCopy.Visible = True

        SpecToCopyData.DataBind()
        ddlSpecToCopy.DataBind()

        ddlSpecToCopy.Items.Insert(0, New ListItem("- Choose Specification", "-1"))

    End Sub

    Protected Sub ddlSpecToCopy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlSpecToCopy.SelectedIndexChanged

        Dim cts As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("cnsCoreData")
        Dim cnnCore As New SqlClient.SqlConnection(cts.ConnectionString)

        Dim sqlSlctdSpec As String = String.Empty
        Dim cmdSlctdSpec As SqlClient.SqlCommand
        Dim dtrSlctdSpec As SqlClient.SqlDataReader
        Dim lngSpecSrcID As Long = 0
        Dim lngCustomerID As Long = 0
        Dim lngStndrdsOrgID As Long = 0

        InitializeLoadSpec()
        SetForNewSpecEntry(False, False)

        cnnCore.Open()

        lngCopySpecID = ddlSpecToCopy.SelectedValue

        sqlSlctdSpec = "SELECT SpecID, CustomerID, StandardsOrgID, SpecNmbr, SpecTitle " _
                            & "FROM Specifications WHERE (((SpecID)=" & lngCopySpecID & "));"

        cmdSlctdSpec = New SqlClient.SqlCommand(sqlSlctdSpec, cnnCore)
        dtrSlctdSpec = cmdSlctdSpec.ExecuteReader

        divActivityInfo.Visible = False
        btnSaveSpec.Visible = True

        lblSpecTitle.Visible = True
        txtSpecTitle.Visible = True
        rblSourceType.Visible = True

        If dtrSlctdSpec.HasRows Then
            While dtrSlctdSpec.Read
                lngCustomerID = dtrSlctdSpec("CustomerID")
                lngStndrdsOrgID = dtrSlctdSpec("StandardsOrgID")
                txtSpecTitle.Text = dtrSlctdSpec("SpecTitle")
                txtSpecTitle_TextChanged(txtSpecTitle, New EventArgs())
                strCopySpecNmbr = dtrSlctdSpec("SpecNmbr")
                If lngCustomerID > 0 Then
                    lngSpecSrcID = lngCustomerID
                    If lngCustomerID = 12 Then
                        rblSourceType.SelectedValue = 3
                    Else
                        rblSourceType.SelectedValue = 1
                    End If
                ElseIf lngStndrdsOrgID > 0 Then
                    lngSpecSrcID = lngStndrdsOrgID
                    rblSourceType.SelectedValue = 2
                End If
            End While
        End If

        rblSourceType_SelectedIndexChanged(sender:=Nothing, e:=Nothing)

    End Sub

    Protected Sub rblSourceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rblSourceType.SelectedIndexChanged

        Try

            ddlSpecSource.Items.Clear()
            ddlSpecSource.ClearSelection()

            If rblSourceType.SelectedValue = 1 Then
                SpecSourceData.SelectCommand = "SELECT CustomerID, Customer FROM LUCustomers WHERE (IsCurrent = @IsCurrent) ORDER BY Customer"
                ddlSpecSource.DataValueField = "CustomerID"
                ddlSpecSource.DataTextField = "Customer"
            ElseIf rblSourceType.SelectedValue = 2 Then
                SpecSourceData.SelectCommand = "SELECT StandardsOrgID, RTrim(StandardsOrgCode) + ' - ' + RTrim(StandardsOrganization) 
AS StndrdsOrg FROM LUStandardsOrganizations ORDER BY RTrim(StandardsOrgCode) + ' - ' + RTrim(StandardsOrganization)"
                ddlSpecSource.DataValueField = "StandardsOrgID"
                ddlSpecSource.DataTextField = "StndrdsOrg"
            ElseIf rblSourceType.SelectedValue = 3 Then
                SpecSourceData.SelectCommand = "SELECT CustomerID, Customer FROM LUCustomers WHERE (IsCurrent = @IsCurrent) ORDER BY Customer"
                ddlSpecSource.DataValueField = "CustomerID"
                ddlSpecSource.DataTextField = "Customer"
            End If

            ddlSpecSource.Visible = True
            If lngCopySpecID > 0 Then
                lngCopySrcID = ddlCopyFromSrc.SelectedValue
                SpecSourceData.DataBind()
                ddlSpecSource.DataBind()

                If rblSourceType.SelectedValue = 1 Then
                    If lngCopySpecID > 0 Then
                        ddlSpecSource.SelectedIndex = ddlSpecSource.Items.IndexOf(ddlSpecSource.Items.FindByValue(lngCopySrcID))
                        ddlSpecSource_SelectedIndexChanged(ddlSpecSource, New EventArgs())
                    Else
                        ddlSpecSource.Items.Insert(0, New ListItem("- Choose Customer", "-1"))
                    End If
                ElseIf rblSourceType.SelectedValue = 2 Then
                    If lngCopySpecID > 0 Then
                        ddlSpecSource.SelectedIndex = ddlSpecSource.Items.IndexOf(ddlSpecSource.Items.FindByValue(lngCopySrcID))
                        ddlSpecSource_SelectedIndexChanged(ddlSpecSource, New EventArgs())
                    Else
                        ddlSpecSource.Items.Insert(0, New ListItem("- Choose Standards Organization", "-1"))
                    End If
                ElseIf rblSourceType.SelectedValue = 3 Then
                    ddlSpecSource.SelectedValue = 12
                    ddlSpecSource_SelectedIndexChanged(ddlSpecSource, New EventArgs())
                End If

        Catch ex As Exception
            Debug.Print("Error - LoadSpec.aspx.vb - rblSourceType_SelectedIndexChanged " & Chr(13) _
                        & "Msg = " & ex.Message.ToString & ". Trace:  " & ex.StackTrace)
        End Try

    End Sub

    Protected Sub ddlSpecSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlSpecSource.SelectedIndexChanged

        Dim strCustomer As String
        Dim strStndrdsOrg As String

        If rblSourceType.SelectedValue = 1 Then
            Session("ssnCustomerID") = ddlSpecSource.SelectedValue
            strCustomer = ddlSpecSource.SelectedItem.Text
            Session("ssnStndrdsOrgID") = 0
        ElseIf rblSourceType.SelectedValue = 2 Then
            Session("ssnStndrdsOrgID") = ddlSpecSource.SelectedValue
            strStndrdsOrg = ddlSpecSource.SelectedItem.Text
            Session("ssnCustomerID") = 0
        End If

        If lngCopySpecID > 0 Then
            rblCstmrOrStndrd.Visible = False
            lblCstmrOrStndrd.Visible = False
            lblCopyFromSrc.Visible = False
            ddlCopyFromSrc.Visible = False
            lblSpecToCopy.Visible = False
            ddlSpecToCopy.Visible = False
        End If

        If rblSourceType.SelectedValue = 1 Then
            SetupAutoDivisions(0)
        End If

        lblSpecNmbr.Visible = True
        txtSpecNmbr.Visible = True
        lblRevNmbr.Visible = True
        txtRevNmbr.Visible = True

        If lngCopySpecID > 0 Then
            txtSpecNmbr.Text = strCopySpecNmbr
        Else
            txtSpecNmbr.Text = ""
        End If
        txtRevNmbr.Text = ""
        txtRevNmbr.Focus()

    End Sub

End Class