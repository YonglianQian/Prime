<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication0503.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:DataList ID="DataList1" runat="server" DataKeyField="Id" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    Id:
                    <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    <br />
                    Name:
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    <br />
                    Price:
                    <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                    <br />
                </ItemTemplate>
            </asp:DataList>
            

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataStoreConnectionString %>" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
            <input id="animals" list="animal" runat="server" onserverchange="animals_ServerChange" type="text"/>
            <datalist id="animal" runat="server">
                <option value="Dog"></option>
                <option value="Cat"></option>
                <option value="Lion"></option>
            </datalist>
           
        </div>
    </form>
</body>
</html>
