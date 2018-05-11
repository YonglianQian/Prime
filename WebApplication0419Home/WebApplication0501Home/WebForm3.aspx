<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication0501Home.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>

    <style type="text/css">
        [class*=col-] input[type="text"]{
            min-width:80%;
        }

    </style>
    
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="row">
            <div class="col-lg-8 offset-lg-2 not-full-length">

                <p>
                    <asp:TextBox ID="Textbox1" runat="server" MaxLength="30"></asp:TextBox></p>
            </div>
        </div>
    </form>
</body>
</html>
