<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication0420.WebForm6" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

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



            <asp:Table ID="Table1" runat="server" CellPadding="5"
GridLines="horizontal" HorizontalAlign="Center">
   <asp:TableRow>
     <asp:TableCell>
         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></asp:TableCell>
     <asp:TableCell>2</asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
     <asp:TableCell>3</asp:TableCell>
     <asp:TableCell>4</asp:TableCell>
   </asp:TableRow>
</asp:Table> 
        </div>
    </form>
</body>
</html>
