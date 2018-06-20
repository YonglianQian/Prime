<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm13.aspx.cs" Inherits="WebApplication0612.WebForm13" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Button runat="server" Text="Button" ID="Button1" OnClick="Unnamed1_Click" />
                    <asp:Label runat="server" Text="Intial" ID="Label1"></asp:Label>
                </ContentTemplate>

            </asp:UpdatePanel>

            <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1" DynamicLayout="False">
                <ProgressTemplate>
                    <strong>Processing....</strong>
                </ProgressTemplate>
            </asp:UpdateProgress>


            

        </div>
    </form>
</body>
</html>
