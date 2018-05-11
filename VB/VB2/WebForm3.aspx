<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm3.aspx.vb" Inherits="VB2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header class="page-header" style="display: inline; margin-bottom: 25px;">
            <div class="row">
                <div class="col-lg-6">
                    <h4 id="lblPgTitle">Load New Spec </h4>
                    <h5 id="lblPgSubTitle">Full process loads Specification, Tests defined by Spec and Testing Schemes</h5>
                </div>
                <div class="col-lg-4" style="margin-top: 10px">
                    <p>
                        <a id="lkbCreateNewSpec" class="btn btn-primary btn-md" data-toggle="modal" data-target="#mdlEntryChk">New Spec</a>
                        <asp:Button ID="btnNewSpecFromCopy" runat="server" Text="Copy" Visible="true" CssClass="btn btn-primary btn-md" />
                        <asp:Button ID="btnStartAnother" runat="server" Text="Start Another" Visible="false" CssClass="btn btn-primary btn-md" />
                        <asp:Button ID="btnSpecView" runat="server" Text="Logged Specs" Visible="false" CssClass="btn btn-primary btn-md" />
                    </p>
                </div>
                <div class="col-lg-2">
                    <img src="images/TRSLogoQ60-2.png" alt="" style="height: 45px;" />
                </div>
            </div>
        </header>
        <br />

        <div class="row col-lg-12 form-group">
            <div id="divActivityInfo" runat="server" visible="false" class="">
                <h4 id="hmlMsgTitle" title="" runat="server" visible="false"></h4>
                <%--                <asp:Label ID="lblMsgTitle" runat="server" CssClass="h4 alert" Text="" Visible="false"></asp:Label>
                <br />--%>
                <asp:Label ID="lblMsg" runat="server" Text="" Visible="false"></asp:Label>
            </div>
        </div>

        <div class="row">
            <div class="col-lg-12" style="padding-left: 0px">
                <div class="control-group">
                    <label for="rblCstmrOrStndrd" id="lblCstmrOrStndrd" class="control-label" visible="false" runat="server">Source</label>
                    <asp:RadioButtonList ID="rblCstmrOrStndrd" CssClass="RadioButton RadioButtonList" runat="server"
                        RepeatDirection="Horizontal" AutoPostBack="true" Visible="false" RepeatLayout="Flow"
                        OnSelectedIndexChanged="rblCstmrOrStndrd_SelectedIndexChanged">
                        <asp:ListItem class="radio-inline" Value="1">Customer</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="2">Industry Standard</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-lg-4" style="padding-left: 0px">
                <div class="form-group">
                    <asp:Label ID="lblCopyFromSrc" AssociatedControlID="ddlCopyFromSrc" CssClass="control-label" runat="server"
                        Text="" Visible="false"></asp:Label>
                    <asp:DropDownList ID="ddlCopyFromSrc" CssClass="form-control" DataSourceID="CopyFromSrcData"
                        AutoPostBack="true" DataValueField="" DataTextField="" Visible="false" runat="server"
                        AppendDataBoundItems="true" OnSelectedIndexChanged="ddlCopyFromSrc_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="CopyFromSrcData" runat="server"
                        ConnectionString="<%$ ConnectionStrings:cnsCoreData %>"
                        SelectCommand="">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="1" Name="IsCurrent" Type="Int16" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
            </div>
            <div class="col-lg-8" style="padding-right: 0px">
                <div class="form-group">
                    <asp:Label ID="lblSpecToCopy" AssociatedControlID="ddlSpecToCopy" CssClass="control-label" runat="server"
                        Text="Specification" Visible="false"></asp:Label>
                    <asp:DropDownList ID="ddlSpecToCopy" CssClass="form-control" DataSourceID="SpecToCopyData"
                        AutoPostBack="true" DataValueField="SpecID" DataTextField="Spec"
                        AppendDataBoundItems="true" Visible="false" runat="server"
                        OnSelectedIndexChanged="ddlSpecToCopy_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SpecToCopyData" runat="server"
                        ConnectionString="<%$ ConnectionStrings:cnsCoreData %>"
                        SelectCommand="">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="ddlCopyFromSrc" Name="SlctdSrcID" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
            </div>
        </div>

        <%--        <div class="row">
            <div class="col-lg-12" style="padding-left:0px;padding-right:0px">
                <div class="form-group">
                    <asp:Label ID="lblStndrdToCopy" AssociatedControlID="ddlStndrdToCopy" CssClass="control-label" runat="server" 
                                    Text="Supplemental Spec(s)" Visible="false"></asp:Label>            
                    <asp:DropDownList ID="DropDownList1" CssClass="form-control" DataSourceID="SpecToCopyData" 
                                                AutoPostBack="true" DataValueField="" DataTextField="" 
                                                AppendDataBoundItems="true" Visible="false" runat="server" 
                                                OnSelectedIndexChanged="ddlSpecToCopy_SelectedIndexChanged" >
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:cnsCoreData %>" 
                                                    SelectCommand="SELECT DISTINCT Specifications.SpecID, RTrim(Specifications.SpecNmbr) 
                                                                            + ' Rev ' + RTrim(Specifications.SpecRev) AS Spec FROM Specifications 
                                                                            LEFT JOIN SpecToCustomer ON Specifications.SpecID = SpecToCustomer.SpecID 
                                                                            WHERE (SpecToCustomer.CustomerID=@CstmrID) 
                                                                            ORDER BY RTrim(Specifications.SpecNmbr) + ' Rev ' + RTrim(Specifications.SpecRev)">
                        <SelectParameters>
                            <asp:Parameter Name="CstmrID"  Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>  
                </div>  
            </div>
        </div>--%>


        <div class="row">
            <div class="col-lg-11">
                <div class="form-group">
                    <asp:Label ID="lblSpecTitle" AssociatedControlID="txtSpecTitle" Text="Title" Visible="false" runat="server"></asp:Label>
                    <asp:TextBox ID="txtSpecTitle" CssClass="form-control" Style="width: 100%; max-width: 100%" Visible="false"
                        OnTextChanged="txtSpecTitle_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col-lg-1" style="margin-right: 0px; padding-left: 0px; padding-right: 0px; padding-top: 24px; vertical-align: bottom; align-content: flex-end">
                <asp:Button ID="btnSaveSpec" runat="server" Text="Save New" Visible="false" CssClass="btn btn-primary btn-md" />
            </div>
        </div>

        <%--     Start of 1st column of 2 column form format     --%>

        <div class="col-lg-6">
            <div class="row">
                <div class="control-group">
                    <asp:Label ID="lblSourceType" AssociatedControlID="rblSourceType" Text="Source" Visible="false" runat="server"></asp:Label>
                    <fieldset>
                        <asp:RadioButtonList ID="rblSourceType" CssClass="RadioButton RadioButtonList radio.radiobuttonlist" runat="server"
                            RepeatDirection="Horizontal" AutoPostBack="true" Visible="false" RepeatLayout="Flow"
                            OnSelectedIndexChanged="rblSourceType_SelectedIndexChanged">
                            <asp:ListItem class="radio-inline" Value="1" Text="Customer"></asp:ListItem>
                            <asp:ListItem class="radio-inline" Value="2" Text="Standards Organization"></asp:ListItem>
                            <asp:ListItem class="radio-inline" Value="3" Text="Harman"></asp:ListItem>
                        </asp:RadioButtonList>
                    </fieldset>
                </div>
            </div>
            </div>

            <div class="row">
                <div class="form-group">
                    <asp:DropDownList ID="ddlSpecSource" CssClass="form-control" DataSourceID="SpecSourceData"
                        AutoPostBack="true" DataValueField="" DataTextField=""
                        AppendDataBoundItems="true" Visible="false" runat="server"
                        OnSelectedIndexChanged="ddlSpecSource_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SpecSourceData" runat="server"
                        ConnectionString="<%$ ConnectionStrings:cnsCoreData %>"
                        SelectCommand="">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="1" Name="IsCurrent" Type="Int16" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
            </div>
        
    </form>
</body>
</html>
