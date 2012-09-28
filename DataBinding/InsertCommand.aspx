<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InsertCommand.aspx.cs" Inherits="InsertCommand" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient" ConnectionString="<%$ ConnectionStrings: nashNorthwind %>" DataSourceMode="DataSet" 
        SelectCommand="select * from Employees"
        InsertCommand="insert into Employees values (@EmployeeID, @FirstName, @LastName, @TitleOfCourtesy)"></asp:SqlDataSource>

        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" DataSourceID="SqlDataSource1"
        AutoGenerateInsertButton="true">        
        </asp:DetailsView>
    </div>
    </form>
</body>
</html>
