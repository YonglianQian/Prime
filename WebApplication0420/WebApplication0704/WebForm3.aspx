<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication0704.WebForm3" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/smoothness/jquery-ui.css" />
    <script src="//code.jquery.com/jquery-1.12.4.js"></script>
    <script src="//code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script>

</script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>

            <asp:GridView ID="Gridview1" runat="server" ShowFooter="true" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="RowNumber" HeaderText="Row Number" />
                    <asp:TemplateField HeaderText="Header 1">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Header 2">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Header 3">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </ItemTemplate>
                        <FooterStyle HorizontalAlign="Right" />
                        <FooterTemplate>
                            <asp:Button ID="ButtonAdd" runat="server" Text="Add New Row" OnClick="ButtonAdd_Click" />
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id"></asp:DropDownList>


            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
