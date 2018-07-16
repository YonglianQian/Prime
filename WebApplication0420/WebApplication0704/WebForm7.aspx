<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication0704.WebForm7" %>

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
                    <asp:CommandField ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                </Columns>
                <EditRowStyle BackColor="#99CCFF" BorderStyle="None" />
                <SelectedRowStyle ForeColor="#FF66FF" />

            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="Data Source=(localdb)\mssqllocaldb;Initial Catalog=DataStore;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework" DeleteCommand="DELETE FROM [Products] WHERE [Id] = @original_Id AND [Name] = @original_Name AND [Price] = @original_Price" InsertCommand="INSERT INTO [Products] ([Name], [Price]) VALUES (@Name, @Price)" OldValuesParameterFormatString="original_{0}" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Products]" UpdateCommand="UPDATE [Products] SET [Name] = @Name, [Price] = @Price WHERE [Id] = @original_Id AND [Name] = @original_Name AND [Price] = @original_Price">
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
