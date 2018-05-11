<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication0419Home.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script type="text/javascript">
        function ShowOptions(s, e) {
            console.log(s);
            console.log(e);
            $("#AutoCompleteExtender1_completionListElem li").each(function (i) {
                //var result = $(this).text();
                //var array = result.split(',');
                //array.splice(2, 1);
                //var result1 = array.join(',');
                //$(this).text(result1);
            });
        }




        //WCF函数
        function HelloWorld() {
            var result = $("#Text1").val();
            Service1.HelloWorld(result, helloWorldCallback);
        }
        function helloWorldCallback(result) {
            alert(result);
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/Service1.svc" />
            </Services>
        </asp:ScriptManager>


        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            <hr style="color: red; background-color: darkred" />
            <br />
            <div>
                调用webService
            </div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="TextBox1"
                ServicePath="WebService1.asmx" ServiceMethod="GetData" MinimumPrefixLength="1" OnClientShowing="ShowOptions">
            </ajaxToolkit:AutoCompleteExtender>
        </div>
        <br />




        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div>调用WCF服务</div>
                <label>输入名字参数</label>
                <input id="Text1" type="text" />
                <input id="Button2" type="button" value="点击调用" onclick="HelloWorld();" />

            </ContentTemplate>

        </asp:UpdatePanel>
    </form>
</body>
</html>
