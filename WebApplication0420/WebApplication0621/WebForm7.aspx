<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication0621.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                    <asp:GridView ID="DataGridView"  runat="server" 
                AutoGenerateColumns="false" 
                AllowPaging="True" 
                AllowSorting="True" PageSize="15" 
                 Width="100%" Font-Names="Arial" Font-Size="Large" OnPageIndexChanging="DataGridView_PageIndexChanging" OnSorting="DataGridView_Sorting">
                <AlternatingRowStyle BackColor="#FFCC99" />
                <Columns>
                    <asp:CommandField  ButtonType="Button" SelectText="Edit"  ShowSelectButton="True" 
                    ItemStyle-HorizontalAlign="Center" ItemStyle-Width="65px"  />

                    <asp:BoundField DataField="Account" HeaderText="Account" SortExpression="Account" />
                    <asp:BoundField DataField="Sequence" HeaderText="Sequence" SortExpression="Sequence" />
                    <asp:BoundField DataField="Dept" HeaderText="Dept" SortExpression="Dept" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    <asp:BoundField DataField="Type" HeaderText="Type" />
                    <asp:BoundField DataField="MS" HeaderText="MS" />
                    <asp:BoundField DataField="EjGr" HeaderText="EjGr" />
                </Columns>

                <HeaderStyle BackColor="Silver" Font-Names="Arial" Font-Size="Smaller" ForeColor="Black" />
                <SelectedRowStyle BackColor="#0099FF" Font-Names="Arial" />
                <SortedAscendingHeaderStyle BackColor="Aqua" />
                <SortedDescendingHeaderStyle BackColor="#FFFF66" />
                <PagerSettings Mode="NextPreviousFirstLast" Position="top" 
                    FirstPageImageUrl="images\btnfirst.jpg" LastPageImageUrl="images\btnlast.jpg" 
                    NextPageImageUrl="images\btnnext.jpg" PreviousPageImageUrl="images\btnprevious.jpg" />
                <PagerStyle HorizontalAlign="Right" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
