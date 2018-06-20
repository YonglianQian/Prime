<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm11.aspx.cs" Inherits="WebApplication0604.WebForm11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="True" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:DataList ID="MyPnList" runat="server" OnItemCommand="MyPnList_ItemCommand">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Id") %>' ID="label1" runat="server"></asp:Label>
                            <asp:Label Text='<%# Eval("Name") %>' runat="server" ID="label2"/>
                            <asp:Label Text='<%# Eval("Price") %>' runat="server" ID="lablel3"></asp:Label>
                            <asp:Image ID="Image1" runat="server" Height="32px" Width="32px" ImageUrl="~/Image/3.png" />
                            <asp:Button ID="AcceptButton" runat="server" CommandName="Accept"
                                OnClick="AcceptButton_Click" Text="Accept"
                                CausesValidation="False" Width="79px" />
                            <asp:Button ID="Decline" runat="server" CommandName="Decline"
                                OnClick="Decline_Click" Text="Decline" Width="79px" CausesValidation="False" />
                        </ItemTemplate>
                    </asp:DataList>
                    <table style="width: 506px; margin-left: 0px">                          
               <tr>
                <td>
                    <asp:LinkButton ID="lnkbtnPgFirst" runat="server" OnClick="lnkbtnPgFirst_Click" CssClass="auto-style1">First</asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="lnkbtnPgPrevious" runat="server"  OnClick="lnkbtnPgPrevious_Click" CssClass="auto-style1">Previous</asp:LinkButton>
                </td>
                <td>
                    <asp:DataList ID="DataListPaging" runat="server" RepeatDirection="Horizontal" OnItemCommand="DataListPaging_ItemCommand"
                        OnItemDataBound="DataListPaging_ItemDataBound" OnSelectedIndexChanged="DataListPaging_SelectedIndexChanged" style="font-size: small">
                        <ItemTemplate>
                            <asp:LinkButton ID="Pagingbtn" runat="server" CommandArgument='<%# Eval("PageIndex") %>'
                     CommandName="Newpage" Text='<%# Eval("PageText")%>' OnClick="Pagingbtn_Click"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td>
                    <asp:LinkButton ID="lnkbtnPgNext" runat="server" OnClick="lnkbtnPgNext_Click" CssClass="auto-style1">Next</asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="lnkbtnPgLast" runat="server" OnClick="lnkbtnPgLast_Click" CssClass="auto-style1">Last</asp:LinkButton>
                </td>
            </tr>
            <tr>
              <td align="center" height="30" colspan="5" style="background-color:  White">
                    <asp:Label ID="lblpaging" runat="server" Text="" style="font-weight: 700; font-size: small; color: #800000; font-style: italic"></asp:Label>
                </td>
            </tr>
                  </table>

                    
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
