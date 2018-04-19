<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication0419Home.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script type="text/javascript">
        function ShowOptions(s, e) {
            $("#AutoCompleteExtender1_completionListElem li").each(function (i) {
                var result = $(this).text();
                var array = result.split(',');
                array.splice(2, 1);
                var result1 = array.join(',');
                $(this).text(result1);
            });   

        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

            <br />

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="TextBox1"
                ServicePath="WebService1.asmx" ServiceMethod="GetData" MinimumPrefixLength="1"
                OnClientShown="ShowOptions"></ajaxToolkit:AutoCompleteExtender>
        </div>
    </form>
</body>
</html>
