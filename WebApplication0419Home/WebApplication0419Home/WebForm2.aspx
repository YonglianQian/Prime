<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication0419Home.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        $(function () {
            $('input[type=checkbox]').each(function () {
                $(this).change(function () {
                    var flag = false;
                    $('input[type=checkbox]').each(function () {
                        if ($(this).is(':checked')) {
                            flag = !flag;
                        }
                    });
                    if (flag) {
                        $('#Submit1').removeAttr("disabled");
                    }
                    else {
                        $('#Submit1').attr('disabled', 'disabled');
                    }
                });
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="checkbox1" class="check" name="chks[]" value="GLearn" type="checkbox">
            <input id="checkbox2" class="check" type="checkbox" name="chks[]" value="GParent">
            <input id="Submit1" disabled type="submit" value="button" runat="server" onserverclick="Button1_Click" />
        </div>
    </form>
</body>
</html>
