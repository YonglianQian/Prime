<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="WebApplication0621.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                     <asp:DataList ID="DataList1" runat="server" DataKeyField="Id" DataSourceID="SqlDataSource1" GridLines="Both" OnItemDataBound="DataList1_ItemDataBound" OnItemCommand="DataList1_ItemCommand">
                <ItemTemplate>
                    Id:
                    <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                    <br />
                    Name:
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    <br />
                    Description:
                    <%--<asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description").ToString().Length>10?Eval("Description").ToString().Substring(0,10)+"........":Eval("Description").ToString() %>'/>--%>
                    <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>'/>
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Display">See more</asp:LinkButton>
                    <br />
<br />
                </ItemTemplate>
            </asp:DataList>
                </ContentTemplate>
            </asp:UpdatePanel>
           
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyDataStore %>" SelectCommand="SELECT * FROM [Records]"></asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
