<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication0503.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script type="text/javascript">
        $(function () {



            //$.ajax({
            //    url: 'WebService1.asmx/GetData',
            //    type: 'Post',
            //    data: '',
            //    dataType: 'json',
            //    success: function (result) {
            //        debugger;
            //        $.each(result, function (i, o) {
            //            $("#main").append("Name: " + o["Name"] + "<br>");
            //            $("#main").append("Price: " + o["Price"] + "<br>");
            //        }
            //        )
            //    }
            //})

            $.ajax({
                type: "POST",
                url: "WebService1.asmx/GetData2",
                contentType: "application/json",
                data: "{'startingValue':5}",
                dataType: "json",
                success: function (data) {
                    debugger;
                    //console.log(data.d);
                    //var firstValue = data.FirstValue;
                    //var secondValue = data.SecondValue;
                    //console.log("First: " + firstValue + ", Second: " + secondValue);
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    //console.log("Error: " + errorThrown);
                }
            }).done(function (result) {
                debugger;
                //console.log(result);
            });


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
