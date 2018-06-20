<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication0604.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Chart ID="Chart1" runat="server" Width="513px" Height="264px">
<Titles>
<asp:Title Font="Arial, 10pt" Name="Title1"
Alignment="TopLeft">
</asp:Title>
<asp:Title Font="Arial, 10pt" Name="Title2"
Alignment="TopLeft">
</asp:Title> 
</Titles> 
<Series>
<asp:Series ChartType="Pie" Legend="Legend1" Name="Series1" XValueMember="Name" YValueMembers="Price" IsValueShownAsLabel="True" LabelFormat="{0}">
</asp:Series>
</Series>
<ChartAreas>
<asp:ChartArea
Name="DefaultChartArea"
BorderDashStyle="Dot"
BorderWidth="2"
BorderColor="LightGray"
BackColor="White">
<Area3DStyle Enable3D="true" LightStyle="Realistic" />
</asp:ChartArea>
</ChartAreas>
<Legends>
<asp:Legend Name="Legend1" Title="Legend">
</asp:Legend>
</Legends>
</asp:Chart>
        </div>
    </form>
</body>
</html>
