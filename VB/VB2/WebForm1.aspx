<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="VB2.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:Label ID="LblAddFoods" runat="server" Text="Enter food name to search" CssClass="Show"></asp:Label>
            <asp:TextBox ID="txtFoodSearch" runat="server"></asp:TextBox>
            <asp:AutoCompleteExtender ID="aceFoodSearch" runat="server"
                ServiceMethod="SearchFoods"
                ServicePath="~/WebService1.asmx"
                MinimumPrefixLength="3"
                TargetControlID="txtFoodSearch"
                CompletionInterval="100" EnableCaching="False" CompletionSetCount="11">
            </asp:AutoCompleteExtender>
        </div>
    </form>
</body>
</html>
