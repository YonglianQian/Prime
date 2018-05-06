<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WCF0503.WebForm1" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script type="text/javascript">
        $(function () {
            var data = null;
            //Service1.GetData(callback)
            $.ajax({
                url: "Service1.svc/GetData",
                type: "get",
                data: '',
                dataType: 'json',
                success: function (d) {
                    data = d.d;
                }
            }).done(function () {
                $.each(data, function (i, o) {
                    
                    $("#main").append("Name: " + o["Name"] + "<br>");
                })
            })
        });
        //function callback(result){
        //    console.log(result);
        //}


    </script>

</head>
<body>
    <form id="form1" runat="server">
<%--        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/Service1.svc" />
            </Services>
        </asp:ScriptManager>--%>
        <div id="main">

        </div>
        <asp:TextBox runat="server" id="textbox1"/>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

    </form>
</body>
</html>
