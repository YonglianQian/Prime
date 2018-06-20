<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="WebApplication0524.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
        .myclass{
            border:2px dotted #ff6a00;
            background-color:aquamarine;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataSourceID="EntityDataSource1">
                <Columns>
                    <asp:BoundField DataField="FirstName" HeaderText="FIRSTNAME" ReadOnly="True" SortExpression="FIRSTNAME" />
                    <asp:BoundField DataField="LastName" HeaderText="LASTNAME" SortExpression="LASTNAME" ReadOnly="True" />
                    <asp:BoundField DataField="OrderNo" HeaderText="OrderNo" ReadOnly="True" SortExpression="OrderNo" />
                </Columns>
               
            </asp:GridView>
            <asp:EntityDataSource ID="EntityDataSource1" runat="server" CommandText="SELECT ToUpper(P.FIRSTNAME) as FirstName, ToLower(P.LASTNAME) as LastName ,O.ORDERNO FROM PERSONS 
                AS P INNER JOIN ORDERS AS O ON P.ID_P=O.ID_P" 
                ConnectionString="name=DataStoreEntities2" DefaultContainerName="DataStoreEntities2" EnableFlattening="False" Select=""></asp:EntityDataSource>


        </div>
        





    </form>
   
</body>
</html>
