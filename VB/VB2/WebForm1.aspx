<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="VB2.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <%--   <script type="text/javascript">
        function OnKeyDown() {
            var ddl = document.getElementById("<%=DropDownList1.ClientID %>");
            var ac = document.getElementById("<%=aceFoodSearch.ClientID %>");
            ac = $find("<%=aceFoodSearch.ClientID%>");
            var text = ddl.options[ddl.selectedIndex].value;
            if (ac != null) {
                ac.set_contextKey(text);
            }
        }
    </script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:Label ID="LblAddFoods" runat="server" Text="Enter food name to search" CssClass="Show"></asp:Label>
            <%--<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>0</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
            </asp:DropDownList>--%>
            <asp:TextBox ID="txtFoodSearch" runat="server" onkeydown="return OnKeyDown();"></asp:TextBox>
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
