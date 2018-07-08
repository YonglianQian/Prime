<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm12.aspx.cs" Inherits="WebApplication0621.WebForm12" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        $(function () {
            $.ajax({
                url: "WebForm12.aspx/GetData",
                type: "post",
                datatype: "json",
                contentType:"application/json",
                success: function (data) {
                    debugger;
                    var result = $.parseJSON(data);
                    console.log(result);
                }
            })
        })
        
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--<asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>--%>
        </div>
    </form>
</body>
</html>
