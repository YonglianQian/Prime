<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemTemplate.ascx.cs" Inherits="WebApplication0612.ItemTemplate" %>
<tr>
 <td><%# Eval("Id") %></td>
<td><%# Eval("Name") %></td>
<td><%# Eval("Price") %></td>
</tr>