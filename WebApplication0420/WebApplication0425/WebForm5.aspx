<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication0425.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
        <hr style="border:5px solid #00ff21;margin:10px;" />
            <asp:DropDownList ID="DropDownList1" runat="server" >
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataStoreConnectionString2 %>" SelectCommand="SELECT [Id] FROM [Details]"></asp:SqlDataSource>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Download" OnClick="Button2_Click" />
    </form>
</body>
</html>
