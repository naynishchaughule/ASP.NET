<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString="<%$ ConnectionStrings: Nash %>" SelectCommand="select * from mylog">
        </asp:SqlDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="EmployeeDetailsDataUtility"
            SelectMethod="GetEmployees"></asp:ObjectDataSource>
        <asp:Panel ID="Panel1" runat="server" ScrollBars="Auto" Width="800px" Height="250px">
            <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False"
                ShowFooter="True" Caption="My Grid" CellPadding="4" HeaderStyle-BackColor="Azure"
                RowStyle-BackColor="Azure" RowStyle-Font-Italic="true" AllowPaging="True" PageSize="2"
                PagerStyle-BorderColor="BlueViolet" ForeColor="#333333" GridLines="None" OnRowDataBound="GridView1_RowDataBound"
                SelectedRowStyle-BackColor="Pink" DataKeyNames="EmployeeID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                OnRowCommand="GridView1_RowCommand" AllowSorting="true">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField SelectText="click" ShowSelectButton="true" ButtonType="Button" />
                    <asp:ButtonField CommandName="Select" DataTextField="EmployeeID" ButtonType="Button"
                        HeaderImageUrl="~/image.jpg" />
                    <asp:BoundField DataField="EmployeeID" ReadOnly="True" ApplyFormatInEditMode="true"
                        HeaderText="EmployeeID" NullDisplayText="NULL" ConvertEmptyStringToNull="true">
                        <ItemStyle BackColor="Control" />
                    </asp:BoundField>
                    <asp:BoundField DataField="FirstName" ApplyFormatInEditMode="true" HeaderText="Fname"
                        ConvertEmptyStringToNull="true" NullDisplayText="NULL" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="Smaller" ForeColor="White" />
                <PagerStyle BackColor="#284775" BorderColor="BlueViolet" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </asp:Panel>
        <br />
        <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="currentTime" HeaderText="FormattedTime" DataFormatString="{0:M}" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" TypeName="EmployeeDetailsDataUtility"
            SelectMethod="GetEmployee">
            <SelectParameters>
                <asp:ControlParameter Name="EmployeeID" ControlID="GridView1" PropertyName="SelectedDataKey[&quot;EmployeeID&quot;]" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:GridView ID="GridView3" runat="server" DataSourceID="ObjectDataSource2">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
