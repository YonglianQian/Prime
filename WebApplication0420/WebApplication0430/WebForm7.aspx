<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication0430.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.0.0.js"></script>
    <%--<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>--%>
            <script type="text/javascript">
        $(function () {
            //var chardata = null;
            //$.ajax(
            //    {
            //        url: WebService1/GetData,
            //        type: 'Get',
            //        dataType: 'json',
            //        data: '',
            //        success: function (d) {
            //            chardata = d;
            //        }
            //    }
            //).done(function () {
            //    console.log(chardata);
            //})
            WebService1.HelloWorld(callbackresult);
                })
                function callbackresult(result) {
                    console.log(result);
                }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/WebService1.asmx" />
            </Services>
        </asp:ScriptManager>


        <div id="visualization" style="width: 600px; height: 300px">
        </div>
    </form>




</body>
</html>
