Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data.SqlClient

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()>
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class WebService1
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function


    <WebMethod()>
    Public Function SearchFoods(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As Integer) As List(Of String)
        Dim lstfoods As List(Of String) = New List(Of String)
        Dim connectionstring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Using conData As SqlConnection = New SqlConnection(connectionstring)
            conData.Open()
            'Dim strSQL As String = "EXEC kd_selFoodItemsSearch @OrgID,@SearchText ='" & prefixText & "'"
            Dim strSQL As String = "EXEC kd_selFoodItemsSearch @OrgID,@SearchText"
            Dim cmd As SqlCommand = New SqlCommand
            cmd.CommandText = strSQL
            cmd.Parameters.AddWithValue("@OrgID", contextKey)
            cmd.Parameters.AddWithValue("@SearchText", prefixText)
            cmd.Connection = conData
            Dim sdr As SqlDataReader = cmd.ExecuteReader
            While sdr.Read
                lstfoods.Add(sdr("FoodItem").ToString)
            End While
            sdr.Close()
        End Using

        Return lstfoods
    End Function
End Class