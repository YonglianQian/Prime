<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication0704.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="c#" runat="server">
        void Button1_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text = "aaa";
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server">
                <LayoutTemplate>
                    <table border="1">
                        <thead>
                            <th>Name</th>
                            <th>Price</th>
                            <th>Price</th>
                            <th>Price</th>
                        </thead>
                        <tr runat="server" id="itemPlaceholder"></tr>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Name") %>'></asp:Label></td>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text='<%# Math.Round(Convert.ToDouble(Eval("Price"))).ToString("0.00") %>'></asp:Label></td>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# String.Format("{0:N2}", Math.Round(Convert.ToDouble(Eval("Price")))) %>'></asp:Label></td>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text='<%# String.Format("{0:F}", Math.Round(Convert.ToDouble(Eval("Price")))) %>'></asp:Label></td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
