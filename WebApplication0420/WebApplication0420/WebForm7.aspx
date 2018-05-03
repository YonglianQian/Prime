<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication0420.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="LeadNameDropDownList" runat="server" Height="30px" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="LeadNameDropDownList_SelectedIndexChanged"></asp:DropDownList>
            <asp:Label ID="DestinationLabel" runat="server" Text="Destination" Font-Names="Arial" Font-Size="Medium"></asp:Label>
            <br />
            <asp:TextBox ID="DestinationAddress1TextBox" runat="server" Height="30px" Width="200px"></asp:TextBox>
            <br />
            <asp:TextBox ID="DestinationCityTextBox" runat="server" Height="30px" Width="200px"></asp:TextBox>
            <br />
            <asp:TextBox ID="DestinationPostcodeTextBox" runat="server" Height="30px" Width="200px"></asp:TextBox>
            <br />
            <br />
  
        </div>
    </form>
</body>
</html>
