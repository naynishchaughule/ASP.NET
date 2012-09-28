<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CachingWithDataSourceControls.aspx.cs"
    Inherits="CachingWithDataSourceControls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString='<%$ ConnectionStrings: connection %>' SelectCommand="select * from Category">
        </asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2"
            DataTextField="CategoryName" DataValueField="CategoryID" AutoPostBack="true">
        </asp:DropDownList>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString='<%$ ConnectionStrings: connection %>' SelectCommand="select * from Products" DataSourceMode="DataSet" FilterExpression="CategoryID='{0}'" EnableCaching="true">
            <FilterParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="CategoryID" PropertyName="SelectedValue" />
            </FilterParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
