<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="ContentPage.aspx.vb" Inherits="VB1.ContentPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="border:1px solid #ffd800;margin:10px;">
        <h3>ContentPage</h3>
        <asp:Button ID="IbnPeople" runat="server" Text="IbnPeople" />
        <asp:Button ID="IbnPlaces" runat="server" Text="IbnPlaces" />
        <asp:Button ID="IbnThings" runat="server" Text="IbnThings" />
    </div>
</asp:Content>
