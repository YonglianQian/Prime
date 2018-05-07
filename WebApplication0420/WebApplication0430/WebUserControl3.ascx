<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl3.ascx.cs" Inherits="WebApplication0430.WebUserControl3" %>
<div>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>


    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataStoreConnectionString %>" SelectCommand="SELECT * FROM [Product] WHERE ([Name] = @Name)">
        <SelectParameters>
            <asp:Parameter Name="Name" DefaultValue="Event" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</div>