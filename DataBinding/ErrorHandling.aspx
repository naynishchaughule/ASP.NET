<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ErrorHandling.aspx.cs" Inherits="ErrorHandling" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ProviderName="System.Data.SqlClient" 
            ConnectionString="<%$ ConnectionStrings: nashNorthwind %>" 
            DataSourceMode="DataSet" SelectCommand="select * from Employees" 
            onselected="SqlDataSource1_Selected"></asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="EmployeeID" DataValueField="LastName">
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
