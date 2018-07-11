<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication0704.WebForm2" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowDataBound="GridView1_RowDataBound">
               <Columns>
                   <asp:TemplateField>
                       <ItemTemplate>
                           <asp:ImageButton ID="ImageButton1" runat="server" />
                       </ItemTemplate>
                       <ItemStyle BackColor="YellowGreen" Width="80px" />
                       <HeaderStyle BackColor="PaleVioletRed" Width="80px" />
                   </asp:TemplateField>
               </Columns>
            </asp:GridView>
              
        </div>
    </form>
</body>
</html>
