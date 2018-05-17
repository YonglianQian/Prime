<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl2.ascx.cs" Inherits="WebApplication0509.WebUserControl2" %>

<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
    SelectCommand="GetEventBySecret" SelectCommandType="StoredProcedure" 
    UpdateCommand="UpdateEvent [EventId]=@EventId,[EventName]=@EventName,[EventSecret]=@EventSercret,[JustABit]=@JustABit" UpdateCommandType="StoredProcedure">
    <SelectParameters>
        <asp:Parameter Name="EventId" DbType="Guid" />
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="EventId" DbType="Guid" />
        <asp:Parameter Name="EventName" Type="String" />
        <asp:Parameter Name="EventSecret" Type="String" />
        <asp:Parameter Name="JustABit" Type="Boolean" />
    </UpdateParameters>
</asp:SqlDataSource>


<asp:DetailsView ID="DetailsView1" DataKeyNames="EventId" runat="server" AutoGenerateRows="False" OnItemUpdating="DetailsView1_ItemUpdating" DataSourceID="SqlDataSource1">
    <Fields>
        <asp:TemplateField HeaderText="EventId" SortExpression="EventId">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("EventId") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("EventId") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="EventName" SortExpression="EventName">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("EventName") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("EventName") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="EventSecret" SortExpression="EventSecret">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("EventSecret") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("EventSecret") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="JustAbit" SortExpression="JustAbit">
            <EditItemTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Eval("JustAbit").ToString().Equals("1") %>' />
            </EditItemTemplate>
            <ItemTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Eval("JustAbit").ToString().Equals("1") %>' Enabled="false" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" />
    </Fields>
</asp:DetailsView>

