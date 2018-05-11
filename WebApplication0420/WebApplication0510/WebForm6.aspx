<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication0510.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="Button1" />
                </Triggers>
            </asp:UpdatePanel>
            <asp:Button ID="Button1" runat="server" Text="upload" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
