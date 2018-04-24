<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication0420.WebForm5" EnableEventValidation="False" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="http://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script>
        $(function () {

            var array = ["Apple", "Pear"];
            for (var i = 0; i < array.length; i++) {
                    
                $("select").append(
                    '<option value="' + array[i] + '">' + array[i] + '</option>'
                );
                
            }

            //$("#DropDownList1").change(function () {
            //    var selvalue = $("select").find("option:selected").text();
            //    $("#hf1").val(selvalue);
            //})
           
        })
        function display(s, e) {
            debugger;
            var node = $(this);
            var re = $(this).text;
            
            $("#Select1 option:selected").prop("selected", "selected");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="hidden" id="hf1" runat="server" name="user" value="" />
            <%--<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>--%>
        </div>
        <select id="Select1" runat="server" onchange="display(s,e);">
        </select>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
