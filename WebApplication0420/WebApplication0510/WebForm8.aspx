<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="WebApplication0510.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:DropDownList ID="ddlProduct" runat="server" AppendDataBoundItems="True"
                AutoPostBack="True" OnSelectedIndexChanged="ddlProduct_SelectedIndexChanged">
                <asp:ListItem Value="" Selected="True"> - Product - </asp:ListItem>
            </asp:DropDownList>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\mssqllocaldb;Initial Catalog=DataStore;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>

            <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="true"
                OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged" OnDataBound="ddlCategory_DataBound">
                <asp:ListItem Value="" Selected="True"> - Category - </asp:ListItem>
            </asp:DropDownList>






        </div>
    </form>
</body>
</html>
