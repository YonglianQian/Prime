<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication0704.WebForm2" %>


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
                    <asp:TextBox runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </ContentTemplate>
            </asp:UpdatePanel>
                    <asp:TextBox runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
