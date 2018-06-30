<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm3.aspx.vb" Inherits="VB3.WebForm3" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Page-Enter" content="blendTrans(Duration=0.2)" />
    <meta http-equiv="Page-Exit" content="blendTrans(Duration=0.2)" />
    <title></title>
    <script runat="server">

        Shared i
        Shared c = -1
        Shared a

        Shared mm(6, 99)
        Shared dt = 0.01
        Shared dx = 0.1
        Shared AC(6)
        Shared FC(6)
        Shared d = 0
        Shared J = 0
        Shared AA(6)
        Shared CO() = {1, 2, 3, 4, 5, 6, 7}
        Protected Sub Timer1_Tick(sender As Object, e As EventArgs)
            c = c + 1
            While J < 7
                AA(J) = mm(J, c)
                J = J + 1
            End While
            J = 0

            Chart1.Series(0).Points.DataBindXY(CO, AA)
            Label1.Text = c
            Chart1.Series(0).BorderWidth = 2
            Chart1.ResetAutoValues()

        End Sub
        Protected Sub Button1_Click(sender As Object, e As EventArgs)

            i = 0
            While i < 100
                mm(0, i) = Val(TextBox1.Text)
                i = i + 1
            End While
            mm(1, 0) = 1
            mm(2, 0) = 1
            mm(3, 0) = 2
            mm(4, 0) = 2
            mm(5, 0) = 1
            mm(6, 0) = 1
            i = 1
            a = 1
            While i < 100
                While a < 7
                    mm(a, i) = mm(a, i - 1) - ((mm(a, i - 1) * dt / dx) * (mm(a, i - 1) - mm(a - 1, i - 1)))
                    a = a + 1

                End While
                i = i + 1
                a = 1
            End While
            Timer1.Interval = 1000
            Timer1.Enabled = True
        End Sub

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnableCdn="true">
            </asp:ScriptManager>
            <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick">
            </asp:Timer>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>

                <ContentTemplate>


                    <div style="position: absolute; width: 622px; height: 365px; z-index: 1; left: 751px; top: 127px" id="layer1">
                        <div style="position: absolute; width: 100px; height: 46px; z-index: 1; left: -153px; top: 271px" id="layer6">
                            &nbsp;
                        </div>
                        <div style="position: absolute; width: 100px; height: 46px; z-index: 1; left: -154px; top: 205px" id="layer5">
                            &nbsp;
                        </div>
                        <div style="position: absolute; width: 100px; height: 46px; z-index: 1; left: -154px; top: 135px" id="layer4">
                            &nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        </div>
                        <div style="position: absolute; width: 100px; height: 46px; z-index: 1; left: -155px; top: 72px" id="layer3">
                            &nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="102px"></asp:TextBox>
                        </div>
                        <div style="position: absolute; width: 100px; height: 46px; z-index: 1; left: -156px; top: 11px" id="layer2">
                            &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                        </div>

                        <p>
                            <asp:Chart ID="Chart1" runat="server" Height="329px" Width="611px"
                                ImageLocation="~/charts_0/"
                                ImageStorageMode="UseImageLocation"
                                ImageType="Png">
                                <Series>
                                    <asp:Series ChartType="Line" Name="Series1">
                                    </asp:Series>
                                </Series>
                                <ChartAreas>
                                    <asp:ChartArea Name="ChartArea1">
                                    </asp:ChartArea>
                                </ChartAreas>
                            </asp:Chart>
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </form>
</body>
</html>
