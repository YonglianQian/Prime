<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewPhotoAlbum.aspx.cs" Inherits="ListViewAndEF.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Create New PhotoAlbum</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DefaultMode="Insert" InsertMethod="DetailsView1_InsertItem">
                <Fields>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:CommandField ShowCancelButton="False" ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>

        </div>
    </form>
</body>
</html>
