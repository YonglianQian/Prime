<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication0524.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="XmlDataSource1" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="Title">
                        <ItemTemplate>
                            <%--<asp:Label Text='<%# XPath("title") %>' runat="server" id="label1"/>--%>
                            <%--<p><%#XPath("title")%></p>--%>
                            <p><%#DataBinder.Eval(Container.DataItem, "siteMapNode.title")%></p>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/1.xml" Xpath="/siteMapNode/siteMapNode[*]"></asp:XmlDataSource>

        </div>
    </form>
</body>
</html>
