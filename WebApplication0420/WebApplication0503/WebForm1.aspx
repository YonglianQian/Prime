<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication0503.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $.ajax({
                url: 'WebService1.asmx/GetData',
                type: 'post',
                data: '',
                dataType: 'json',

                success: function (result) {
                    $.each(result, function (i, o) {
                        $("#main").append("Name: " + o["Name"] + "<br>");
                        $("#main").append("Price: " + o["Price"] + "<br>");
                    }
                    )
                }

            })

        })


    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div id="main">
        </div>
        前后端调用WebService
    </form>
</body>
</html>
