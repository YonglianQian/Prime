<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication0716.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script src="http://harvesthq.github.io/chosen/chosen.jquery.js"></script>
    <script>
        function Func() {
            var size = document.getElementById("D1").options.length;
            if ($("#D1").attr("size") == size) {
                $("#D1").attr("size", 1);
            } else {
                $("#D1").attr("size", size);
                $("#D1").focus();
            }
        }
    </script>
            <script type="text/javascript">
        $(function() {
            $("#btnAdd").click(function () {
                $('#D1').trigger('chosen:open');
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="Button2" type="button" value="button" onclick="Func()" />
            <input id="btnAdd" type="button" value="button2" />

            <br />
            <asp:DropDownList ID="D1" TabIndex="59" runat="server"  DataValueField="Name" DataTextField="Name"
                DataSourceID="sqldatasource1" OnSelectedIndexChanged="D1_SelectedIndexChanged" AppendDataBoundItems="True" AutoPostBack="True"
                ForeColor="Black">
                <asp:ListItem Text="Select Item Name"></asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataStoreConnectionString %>" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
