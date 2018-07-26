<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication0723.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.css" />
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.jquery.min.js"></script>
    <script>
        $(function () {
            $(".chzn-select").chosen({
                search_contains: true
            });
        });

        $("html").keydown(function (e) {
            // Enter was pressed without shift key
            if (e.keyCode == 87 && e.shiftKey) {
                // prevent default behavior
                e.preventDefault();

                $('.chzn-select').each(function () {
                    $(this).trigger('chosen:open');
                });

            }
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <h2>WebForm3</h2>
        <div>
              <asp:DropDownList ID="D1" TabIndex="59" runat="server" class="chzn-select">
            <asp:ListItem Text="Select Item Name"></asp:ListItem>
            <asp:ListItem Text="United States" Value="United States" />
            <asp:ListItem Text="India" Value="India" />
            <asp:ListItem Text="France" Value="France" />
            <asp:ListItem Text="Russia" Value="Russia" />
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList1" TabIndex="59" runat="server" class="chzn-select">
            <asp:ListItem Text="Select Item Name"></asp:ListItem>
            <asp:ListItem Text="United States" Value="United States" />
            <asp:ListItem Text="India" Value="India" />
            <asp:ListItem Text="France" Value="France" />
            <asp:ListItem Text="Russia" Value="Russia" />
        </asp:DropDownList>
        </div>
    </form>
</body>
</html>
