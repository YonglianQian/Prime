<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication0509.WebForm1" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:WebUserControl1 runat="server" id="WebUserControl1" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button1" OnClick="Button1_Click" />
            <input id="submit" type="submit" value="button" onserverclick="submit_ServerClick" />
        </div>

    </form>
</body>
</html>
