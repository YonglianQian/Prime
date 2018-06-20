<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication0612.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/jquery.table2excel.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#Button1").click(function(){  
            console.log(1)  
            $("#GridView1").table2excel({  
                exclude: ".noExl",  
                name: "Excel Document Name",  
                filename: "myFileName",  
                exclude_img: true,  
                exclude_links: true,  
                exclude_inputs: true
            }); 
        })
        }) 
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div runat="server" id="div1" style="border: 1px dashed #ff6a00;">
        </div>
        <hr />
        <asp:Button ID="Button2" runat="server" Text="Generate" OnClick="Button2_Click" />
        <asp:Button ID="Button1" runat="server" Text="Download" />
    </form>
</body>
</html>
