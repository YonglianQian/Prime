﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication0509.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>test</title>
    <script src="https://cdn.bootcss.com/jquery/1.9.0/jquery.min.js"></script>
    <link href="https://cdn.bootcss.com/morris.js/0.5.1/morris.css" rel="stylesheet">
    <script src="https://cdn.bootcss.com/raphael/2.1.0/raphael-min.js"></script>
    <script src="https://cdn.bootcss.com/morris.js/0.5.1/morris.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $.ajax({
                url: "WebService1.asmx/GetData",
                type: 'post',
                data: '',
                datatype: 'json',
                success: function (result1) {
                    var line = new Morris.Line({
                        element: 'myfirstchart',
                        resize: true,
                        data: result1,
                        xkey: 'y',
                        ykeys: ['Points'],
                        labels: ['Points '],
                        lineColors: ['#3c8dbc'],
                        hideHover: 'auto'
                    });
                }
            })
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
            <div id="myfirstchart" style="height: 250px;" class="graph"></div>
    </form>

</body>
</html>
