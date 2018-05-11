<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication0510.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function DisplayDetails(row) {
            var grid = document.getElementById('gridview1');
            //var rowindex = parseInt(row) + 1;  
            document.getElementById("textBox1").value = grid.rows[row+1].cells[0].innerText;
            //document.getElementById("textBox2").value = grid.rows[rowindex].cells[1].innerText;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridview1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" OnRowDataBound="GridView1_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\mssqllocaldb;Initial Catalog=DataStore;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
            <asp:TextBox ID="textBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="textBox2" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
