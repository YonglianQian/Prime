<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication0503.WebForm3" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="border: 2px solid #ff0000; margin: 5px">
        <h3>Webform3</h3>
        <uc1:WebUserControl1 runat="server" ID="WebUserControl1" />
        <div id="div1" runat="server">
        </div>
    </div>
</asp:Content>
