<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication0612.WebForm2" %>

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
                    <asp:GridView CssClass="myGridClass" ID="GridView1" runat="server" AutoGenerateColumns="False"
                        OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
                        OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting"
                        OnRowDataBound="OnRowDataBound" OnSelectedIndexChanged="OnSelectedIndexChanged">
                        <Columns>
                            <asp:TemplateField HeaderText="Choose">
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkRow" runat="server" OnCheckedChanged="GetSelectedRecords" AutoPostBack="true" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ISSUE NUMBER" ItemStyle-Width="50">
                                <ItemTemplate>
                                    <asp:Label ID="Number" runat="server" Text='<%# Eval("IssueNumber") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="Number" runat="server" Text='<%# Eval("IssueNumber") %>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <asp:GridView ID="gvSelected" runat="server" AutoGenerateColumns="False" Visible="false">
                        <Columns>
                            <asp:BoundField DataField="IssueSubject" HeaderText="IssueSubject" SortExpression="IssueSubject" />
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </form>
</body>
</html>
