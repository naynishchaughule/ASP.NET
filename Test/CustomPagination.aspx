<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomPagination.aspx.cs"
    Inherits="CustomPagination" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" EnablePaging="true" TypeName="EmployeeDetailsDataUtility"
            SelectMethod="GetEmployees" SelectCountMethod="CountEmployees"></asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AllowPaging="true"
            SelectedRowStyle-BackColor="Blue" EnableSortingAndPagingCallbacks="true" AutoGenerateColumns="false">
            <%--<PagerSettings Mode="NextPrevious" PreviousPageText="< Back" NextPageText="Forward >" />--%>
            <PagerSettings Mode="Numeric" PageButtonCount="1" />
            <PagerStyle BackColor="Azure" ForeColor="Black" />
            <Columns>
                <asp:ButtonField CommandName="Select" DataTextField="EmployeeID" ButtonType="Button" />
                <asp:BoundField DataField="FirstName" HeaderText="Fname" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
