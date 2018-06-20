<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication0604.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server" style="margin: 50px; clip: rect(auto, auto, auto, auto)" submitdisabledcontrols="True">
        <h1 style="border-style: solid; background-color: aquamarine; width: 866px; color: #0000FF; text-align: center;">Open Time Slots by Provider</h1>
        <div>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <asp:Timer ID="Timer3" runat="server" OnTick="Timer3_Tick">
        </asp:Timer>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">

            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" PageSize="20" AutoGenerateColumns="False" Width="875px" DataKeyNames="ID">

                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID">
                        </asp:BoundField>
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name">
                        </asp:BoundField>
                        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price">
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer3" EventName="Tick" />
            </Triggers>

        </asp:UpdatePanel>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Products]" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>"></asp:SqlDataSource>

        <asp:Timer ID="Timer2" runat="server" OnTick="Timer2_Tick">

        </asp:Timer>

    </form>
</body>
</html>
