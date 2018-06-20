<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication0524.WebForm5" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="TextBox1" runat="server" autocomplete="nope"></asp:TextBox>
            <asp:TextBox ID="txtName" runat="server" AutoCompleteType="Disabled"></asp:TextBox><br />
            <asp:TextBox ID="txtCity" runat="server" AutoCompleteType="Disabled"></asp:TextBox>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="Id_P">
                <Columns>
                    <asp:BoundField DataField="Id_P" HeaderText="Id_P" InsertVisible="False" ReadOnly="True" SortExpression="Id_P" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                </Columns>
            </asp:GridView>


            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="Data Source=(localdb)\mssqllocaldb;Initial Catalog=DataStore;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"
                ProviderName="System.Data.SqlClient"
                SelectCommand="SELECT * FROM [Persons]" 
                EnableCaching="True"
                OnFiltering="SqlDataSource1_Filtering">
                <FilterParameters>
                    <asp:ControlParameter ControlID="txtName" Name="Name" PropertyName="Text" ConvertEmptyStringToNull="false"/>
                    <asp:ControlParameter ControlID="txtCity" Name="City" PropertyName="Text" ConvertEmptyStringToNull="false"/>
                </FilterParameters>
            </asp:SqlDataSource>




            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
