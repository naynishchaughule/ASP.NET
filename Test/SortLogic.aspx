<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SortLogic.aspx.cs" Inherits="SortLogic" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
            AutoPostBack="true">
            <asp:ListItem Text="Sort by ID" Value="EmployeeID"></asp:ListItem>
            <asp:ListItem Text="Sort by First Name" Value="FirstName"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="EmployeeDetailsDataUtility"
            SelectMethod="GetObjectEmployees" SortParameterName="sortExpression" EnablePaging="true"></asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AllowSorting="True"
            AutoGenerateColumns="False" SelectedRowStyle-BackColor="Aqua" DataKeyNames="EmployeeID"
            EnablePersistedSelection="True" OnSorting="GridView1_Sorting" AllowPaging="true" PageSize="2">
            <Columns>
                <asp:CommandField ButtonType="Button" SelectText="select" ShowSelectButton="true" />
                <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" SortExpression="EmployeeID" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="TitleOfCourtesy" HeaderText="TitleOfCourtesy" SortExpression="TitleOfCourtesy" />
            </Columns>
            <SelectedRowStyle BackColor="Aqua"></SelectedRowStyle>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
