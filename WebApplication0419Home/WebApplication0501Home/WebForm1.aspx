<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication0501Home.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <%--<script src="Scripts/jquery-3.3.1.js"></script>--%>
    <script type="text/javascript">
        
        function btn_click() {
            Service1.GetReviews(callback);    
        }
        function callback(result) {
            console.log(result);
        }
    </script>
</head>
<body>

    <form id="form1" runat="server">
        <div>
        <asp:ScriptManager runat="server" ID="ScriptManager1">
            <Services>
                <asp:ServiceReference Path="~/Service1.svc" />
            </Services>
        </asp:ScriptManager>
     

        </div>

        <input type="button" id="button4" value="button4" onclick="btn_click();" />

        

    </form>
</body>
</html>
