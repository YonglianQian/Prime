<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication0419Home.WebForm3" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
     <style type="text/css">
        .Background
        {
            background-color: Black;
            filter: alpha(opacity=90);
            opacity: 0.8;
        }
        .Popup
        {
            background-color: #FFFFFF;
            border-width: 3px;
            border-style: solid;
            border-color: black;
            padding-top: 10px;
            padding-left: 10px;
            width: 400px;
            height: 350px;
        }
        .lbl
      {
            font-size:16px;
            font-style:italic;
            font-weight:bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged"
                AutoPostBack="True" />
            <asp:PlaceHolder ID="phProfile" runat="server"></asp:PlaceHolder>
            <asp:HiddenField ID="HF" runat="server"/>
            <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" 
                TargetControlID="HF"
                CancelControlID="Button2" BackgroundCssClass="Background">
            </cc1:ModalPopupExtender>

        </div>
    </form>
</body>
</html>
