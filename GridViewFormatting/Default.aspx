<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="false"
            AlternatingRowStyle-BackColor="ControlLight" OnRowDataBound="GridView1_RowDataBound"
            DataKeyNames="EmployeeID">
            <Columns>
                <asp:CommandField ShowSelectButton="true" ButtonType="Button" />
                <asp:BoundField DataField="EmployeeID" HeaderText="Employee ID" DataFormatString="{0:C}"
                    ItemStyle-Width="300px">
                    <ItemStyle BorderColor="Aqua" />
                </asp:BoundField>
                <asp:BoundField DataField="FirstName" />
                <asp:BoundField DataField="TitleOfCourtesy" />
            </Columns>
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString="<%$ConnectionStrings:Nash%>" SelectCommand="select * from Employees where EmployeeID=@EmployeeID">
            <SelectParameters>
                <asp:ControlParameter Name="EmployeeID" ControlID="GridView1" PropertyName="SelectedDataKey.Values[&quot;EmployeeID&quot;]" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource1">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
