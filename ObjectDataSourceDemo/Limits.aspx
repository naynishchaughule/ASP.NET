<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Limits.aspx.cs" Inherits="Limits" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="EmployeeDetailsDataUtility"
            SelectMethod="GetEmployees"></asp:ObjectDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" TypeName="EmployeeDetailsDataUtility"
            SelectMethod="GetEmployee">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="EmployeeID" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource2">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
