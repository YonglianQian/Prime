<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm4.aspx.vb" Inherits="VB2.WebForm4" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <div id="slideshow" runat="server" class="row">
            <div class="col-xs-12 col-sm-6 col-md-6 col-lg-6 img-responsive">

                <asp:Image ID="ImgSlide" runat="server" Height="300" Width="300" />

                <ajaxToolkit:SlideShowExtender ID="SlideShowExtender1" runat="server" 
                    TargetControlID="ImgSlide" 
                    SlideShowServiceMethod="GetSlides" 
                    SlideShowServicePath="~/WebService2.asmx"
                    AutoPlay="True" 
                    PlayInterval="1000" />
            </div>
        </div>
        
    </form>
</body>
</html>
