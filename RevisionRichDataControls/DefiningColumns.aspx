<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefiningColumns.aspx.cs"
    Inherits="DefiningColumns" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="CategoryDataUtility"
            SelectMethod="Category_GetAllRecords" SortParameterName="sortExpression"></asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False"
            CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="CategoryID"
            OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowSorting="true" EnablePersistedSelection="true">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <%--<asp:CommandField ShowSelectButton="true" ButtonType="Button" SelectText="select" />--%>
                <%--<asp:BoundField DataField="CategoryID" HeaderText="CategoryID" />--%>
                <asp:ButtonField ButtonType="Button" CommandName="Select" DataTextField="CategoryID"
                    HeaderText="CategoryID" />
                <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" SortExpression="CategoryName" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <hr />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString='<%$ ConnectionStrings:connection %>' SelectCommand="select * from Products where CategoryID=@CategoryID">
            <SelectParameters>
                <asp:ControlParameter Name="CategoryID" ControlID="GridView1" PropertyName="SelectedDataKey.Values[&quot;CategoryID&quot;]" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False"
            CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridView2_RowDataBound"
            AllowSorting="true" OnDataBound="GridView2_DataBound" AllowPaging="true" PageSize="3" EnableSortingAndPagingCallbacks="true">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" />
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" DataFormatString="{0:C}" />
                <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            <PagerSettings Mode="NextPrevious" PreviousPageText="< Back" NextPageText="Forward >" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        </asp:GridView>
        <br />
        <hr />
        <br />
        <asp:Label ID="Label1" runat="server" Text="" EnableViewState="false"></asp:Label>
    </div>
    </form>
</body>
</html>
