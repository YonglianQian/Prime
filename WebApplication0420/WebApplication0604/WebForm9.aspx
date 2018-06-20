<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="WebApplication0604.WebForm9" EnableSessionState="False" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>

    <script type="text/javascript">
         function reloaddata() {
            $.ajax({
                url: "WebForm9.aspx/GetData",
                type: 'post',
                datatype: 'json',
                contentType: 'application/json;charset=utf-8',
                success: function (o) {
                    xmlDoc = $.parseXML(o.d);
                    var row = $("[id*=GridView1] tr:last-child").clone(true);
                    $("[id*=GridView1] tr").not($("[id*=GridView1] tr:first-child")).remove();
                    $(xmlDoc).find("Table1").each(function () {
                        $("td", row).eq(0).html($(this).children("Name").text());
                        $("td", row).eq(1).html($(this).children("Price").text());
                        $("[id*=GridView1]").append(row);
                        row = $("[id*=GridView1] tr:last-child").clone(true);
                    })
                }
             })
        }
       
        $(function () {
            reloaddata();
            window.setInterval('reloaddata()', 5000);
        })
       
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
