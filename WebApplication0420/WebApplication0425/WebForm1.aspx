<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication0425.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function checkDate(s, e) {
            debugger;
            if (s._selectedDate<new Date()) {
                alert("you can not select a day earliar than today!");
                s._selectedDate = new Date();
                s._textbox.set_Value(s._selectedDate.format(s._format));
            }
        }

    </script>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" 
                TargetControlID="TextBox1" OnClientDateSelectionChanged="checkDate"/>

        </div>
    </form>
</body>
</html>
