<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication0621.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" DefaultMode="Edit" AutoGenerateRows="false">
                <AlternatingRowStyle BackColor="#CCCCCC" ForeColor="#CC00CC" />
                <EditRowStyle ForeColor="#FF9966" />
                <Fields>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Description" HeaderText="description" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:TemplateField HeaderText="Age" ControlStyle-Width="40px">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Age") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textbox1" runat="server" Text='<%# Eval("Age") %>'></asp:TextBox>
                        </EditItemTemplate>

<ControlStyle Width="40px"></ControlStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Sex" ControlStyle-Width="80px">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Sex") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textbox1" runat="server" Text='<%# Eval("Sex") %>'></asp:TextBox>
                        </EditItemTemplate>

<ControlStyle Width="80px"></ControlStyle>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Job" HeaderText="Job" />
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:Button runat="server" Text="Modify" ID="button1" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Fields>
                <HeaderStyle HorizontalAlign="Center" />
            </asp:DetailsView>
        </div>
    </form>
</body>
</html>
