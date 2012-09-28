<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MethodParameter.aspx.cs"
    Inherits="MethodParameter" %>

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
        <asp:ListBox ID="ListBox1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="EmployeeID"
            DataValueField="EmployeeID" AutoPostBack="true"></asp:ListBox>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" TypeName="EmployeeDetailsDataUtility"
            SelectMethod="GetEmployee" onselecting="ObjectDataSource2_Selecting">
            <SelectParameters>
                <asp:ControlParameter ControlID="ListBox1" Name="EmployeeID" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <%-- <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource2">
        </asp:GridView>--%>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" DataSourceID="ObjectDataSource2">
        </asp:DetailsView>
    </div>
    </form>
</body>
</html>
