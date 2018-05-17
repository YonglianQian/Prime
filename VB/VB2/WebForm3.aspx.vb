Imports System.Data.SqlClient

Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim connection As SqlConnection = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim command As SqlCommand = New SqlCommand("dbo.MyProcedure", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@param1", 3)
        command.Parameters.AddWithValue("@param2", 7)
        Dim p3 As SqlParameter = command.Parameters.Add("@param3", SqlDbType.Int)
        p3.Direction = ParameterDirection.Output

        connection.Open()
        command.ExecuteNonQuery()
        Label1.Text = p3.Value.ToString() 'get the value after execute the storeprocedure
        connection.Close()

    End Sub

End Class