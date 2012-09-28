<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridView.aspx.cs" Inherits="GridView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString="<%$ ConnectionStrings: northwind %>" DataSourceMode="DataSet"
            SelectCommand="GetAllEmployees" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" Font-Names="Verdana"
            Font-Size="X-Small" ForeColor="#333333" CellPadding="4" GridLines="None" AutoGenerateColumns="False"
            DataKeyNames="EmployeeID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
            AllowSorting="true" EnablePersistedSelection="true" AllowPaging="true" PageSize="3" EnableSortingAndPagingCallbacks="true">
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <%--<asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="Select" />--%>
                <asp:ButtonField ButtonType="Button" DataTextField="EmployeeID" CommandName="Select" />
                <%--<asp:BoundField DataField="EmployeeID" HeaderText="ID" />--%>
                <asp:BoundField DataField="FirstName" HeaderText="Fname" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="Lname" SortExpression="LastName" />
                <asp:BoundField DataField="TitleOfCourtesy" HeaderText="Title" SortExpression="TitleOfCourtesy" />
            </Columns>
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString="<%$ ConnectionStrings: northwind %>" DataSourceMode="DataSet"
            SelectCommand="GetEmployee" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="EmployeeID" PropertyName="SelectedDataKey.Values[&quot;EmployeeID&quot;]" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource2" CellPadding="4"
            ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
