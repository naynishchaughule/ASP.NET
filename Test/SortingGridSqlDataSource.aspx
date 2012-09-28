<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SortingGridSqlDataSource.aspx.cs"
    Inherits="SortingGridSqlDataSource" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString="<%$ ConnectionStrings: Nash %>" SelectCommand="select * from Employees"
            DataSourceMode="DataSet"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AllowSorting="true"
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="EmployeeID" HeaderText="ID" SortExpression="EmployeeID" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
