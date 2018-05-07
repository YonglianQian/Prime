<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication0503.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Data Source=(localdb)\mssqllocaldb;Initial Catalog=DataStore;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework" DeleteCommand="DELETE FROM [Product] WHERE [Id] = @original_Id AND [Name] = @original_Name AND [Price] = @original_Price" InsertCommand="INSERT INTO [Product] ([Name], [Price]) VALUES (@Name, @Price)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Product]" UpdateCommand="UPDATE [Product] SET [Name] = @Name, [Price] = @Price WHERE [Id] = @original_Id AND [Name] = @original_Name AND [Price] = @original_Price">
                <DeleteParameters>
                    <asp:Parameter Name="original_Id" Type="Int32" />
                    <asp:Parameter Name="original_Name" Type="String" />
                    <asp:Parameter Name="original_Price" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Price" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Price" Type="Int32" />
                    <asp:Parameter Name="original_Id" Type="Int32" />
                    <asp:Parameter Name="original_Name" Type="String" />
                    <asp:Parameter Name="original_Price" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
