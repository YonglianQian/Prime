<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication0510.WebForm7" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
</head>
<body>
<form id="ListViewTest3" runat="server">
<div>
<h3>Data Manipulation, Sorting, Paging using ListView Control</h3>

<hr />
<asp:Label ID="lblMessage" runat="server" EnableViewState="false" ForeColor="Blue"></asp:Label>
<asp:ListView ID="ListView1" runat="server" ItemPlaceholderID="PlaceHolder1" OnItemEditing="EditListViewItem"
OnItemCanceling="CancelListViewItem" OnItemUpdating="UpdateListViewItem" DataKeyNames="ID"
OnPagePropertiesChanging="PagePropertiesChanging" OnItemInserting="InsertListViewItem"
InsertItemPosition="LastItem" OnItemDeleting="DeleteListViewItem" OnSorting="SortListViewRecords">
<LayoutTemplate>
<table style="width:100%" padding:"4" cellspacing="0">
<tr class="header">
<th style="width: 30%;">
<asp:LinkButton ID="lnkSort1" runat="server" CommandName="Sort" CommandArgument="Name" Text="Name" />
</th>
<th style="width: 50%;">
<asp:LinkButton ID="LinkButton1" runat="server" CommandName="Sort" CommandArgument="Address" Text="Address" />
</th>
<th style="width:20%;">
<asp:LinkButton ID="LinkButton2" runat="server" CommandName="Sort" CommandArgument="Phone" Text="Phone" />
</th>
<th>
Modify
</th>
</tr>
<asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
</table>
</LayoutTemplate>
<ItemTemplate>
<tr class="item">
<td>
<%# Eval("Name") %>
</td>
<td>
<%# Eval("Address") %>
</td>
<td>
<%# Eval("Phone") %>
</td>
<td>
<asp:LinkButton ID="lnkEdit" runat="server" Text="Edit" CommandName="Edit" />
<span onclick="return confirm('Are you sure to delete?')">
<asp:LinkButton ID="lnkDelete" runat="server" Text="Delete" CommandName="Delete" ForeColor="Brown"/>
</span>
</td>
</tr>
</ItemTemplate>
<AlternatingItemTemplate>
<tr>
<td>
<%# Eval("Name") %>
</td>
<td>
<%# Eval("Address") %>
</td>
<td>
<%# Eval("Phone") %>
</td>
<td>
<asp:LinkButton ID="lnkEdit" runat="server" Text="Edit" CommandName="Edit" />
<span onclick="return confirm('Are you sure to delete?')">
<asp:LinkButton ID="lnkDelete" runat="server" Text="Delete" CommandName="Delete" ForeColor="Brown" />
</span>
</td>
</tr>
</AlternatingItemTemplate>
<EditItemTemplate>
<tr class="edititem">
<td>
Name:
<asp:TextBox ID="txtName" runat="server" Text='<%# Eval("Name") %>' />
</td>
<td>
Address:
<asp:TextBox ID="txtAddress" runat="server" Text='<%# Eval("Address") %>' />
</td>
<td>
Phone:
<asp:TextBox ID="txtPhone" runat="server" Text='<%# Eval("Phone") %>' />
</td>
<td>
<span onclick="return confirm('Are you sure to update?')">
<asp:LinkButton ID="btnUpdate" runat="server" Text="Update" CommandName="Update" />
</span>
<asp:LinkButton ID="btnCancel" runat="server" Text="Cancel" CommandName="Cancel" />
</td>
</tr>
</EditItemTemplate>
<EmptyDataTemplate>
<table runat="server" style="">
<tr>
<td>No data was returned.</td>
</tr>
</table>
</EmptyDataTemplate>
<InsertItemTemplate>
<tr class="insert">
<td>
Name:
<asp:TextBox ID="txtName" runat="server" Text='<%# Eval("Name") %>' />
</td>
<td>
Address:
<asp:TextBox ID="txtAddress" runat="server" Text='<%# Eval("Address") %>' />
</td>
<td>
Phone:
<asp:TextBox ID="txtPhone" runat="server" Text='<%# Eval("Phone") %>' />
</td>
<td>
<span onclick="return confirm('Are you sure to insert?')">
<asp:LinkButton ID="btnInsert" runat="server" Text="Insert" CommandName="Insert" />
</span>
</td>
</tr>
</InsertItemTemplate>

</asp:ListView>
<div style="text-align: center; font-weight: bold;">
<asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="5">
<Fields>
<asp:NumericPagerField ButtonCount="5" />
</Fields>
</asp:DataPager>
</div>
</div>
</form>
</body>
</html>