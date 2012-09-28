<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateCommand.aspx.cs" Inherits="UpdateCommand" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString="<%$ ConnectionStrings: nashNorthwind %>" DataSourceMode="DataSet"
            SelectCommand="select * from Employees" UpdateCommand="update Employees set FirstName=FirstName, LastName=LastName, TitleOfCourtesy=TitleOfCourtesy where EmployeeID=original_@EmployeeID and FirstName=original_@FirstName and LastName=original_@LastName and TitleOfCourtesy=original_@TitleOfCourtesy"
            ConflictDetection="CompareAllValues" OldValuesParameterFormatString="original_{0}">
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateEditButton="true">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
