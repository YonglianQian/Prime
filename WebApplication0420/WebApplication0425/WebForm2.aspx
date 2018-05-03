<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication0425.WebForm2" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script type="text/javascript">
        function ClientValidateUserName(s,e) {
            var result = $("#TextBox1").val();
            var reg= /^((0\d{2,3}-\d{7,8})|(1[3584]\d{9}))$/;
            if (reg.test(result)) {
                
                $("#tooltip").text("you pass it").css("color", "green");
                e.IsValid = true;
                
            } else {
                e.IsValid = false;
                $("#tooltip").text("please input correct telephone number").css("color", "red");
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <label id="tooltip">input telephone</label>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" 
                ClientValidationFunction="ClientValidateUserName"></asp:CustomValidator>
            </div>
    </form>
</body>
</html>
