<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication0723.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        * {
            margin: 0;
            border: 0;
            padding: 0;
        }
        #div {
            display:flex;
        }

        #div1, #div2 {
            height:800px;
        }

        #div1 {
            flex:0 0 200px;
            border: 1px solid #00ffff;
        }

        #div2 {
            flex:1 1;

            border: 1px solid #0094ff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Management</h2>
        <div id="div">
            <div id="div1">
                <asp:TreeView ID="TreeView1" runat="server">
                    <Nodes>
                        <asp:TreeNode NavigateUrl="~/WebForm1.aspx" Target="Right" Text="Home" Value="Home">
                            <asp:TreeNode NavigateUrl="~/WebForm2.aspx" Target="Right" Text="New Node" Value="New Node"></asp:TreeNode>
                            <asp:TreeNode NavigateUrl="~/WebForm5.aspx" Target="Right" Text="New Node" Value="New Node"></asp:TreeNode>
                        </asp:TreeNode>
                    </Nodes>
                </asp:TreeView>
            </div>
            <div id="div2">
                <iframe id="Right" name="Right" runat="server" frameborder="0" scrolling="auto" width="100%" height="90%"></iframe>
            </div>
        </div>
    </form>
</body>
</html>
