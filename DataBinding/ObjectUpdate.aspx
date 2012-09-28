<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ObjectUpdate.aspx.cs" Inherits="ObjectUpdate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="EmployeeDetailsDataUtility"
            SelectMethod="GetEmployees" UpdateMethod="UpdateEmployee"></asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateEditButton="true">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
