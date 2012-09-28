<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListView.aspx.cs" Inherits="ListView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString='<%$ ConnectionStrings: connection %>' SelectCommand="select * from Products">
        </asp:SqlDataSource>
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" GroupItemCount="3">
            <EmptyItemTemplate>
                <td runat="server">
                    hello
                </td>
                <td>
                    world
                </td>
                <td>
                    empty
                </td>
            </EmptyItemTemplate>
            <GroupTemplate>
                <table border="1">
                    <tr>
                        <td id="itemPlaceHolder" runat="server">
                        </td>
                    </tr>
                </table>
            </GroupTemplate>
            <LayoutTemplate>
                <table border="1">
                    <tr id="groupPlaceHolder" runat="server">
                        <td>
                        </td>
                    </tr>
                </table>
                <asp:DataPager ID="DataPager1" runat="server" PageSize="2">
                    <Fields>
                        <asp:NextPreviousPagerField ShowFirstPageButton="true" ShowLastPageButton="true"
                            FirstPageText="|&lt;&lt; " LastPageText=" &gt;&gt;|" NextPageText=" &gt; " PreviousPageText=" &lt; " />
                    </Fields>
                </asp:DataPager>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%# Eval("CategoryID") %>
                    </td>
                    <td>
                        <%# Eval("ProductID") %>
                    </td>
                    <td>
                        <%# Eval("ProductName") %>
                    </td>
                    <td>
                        <%# Eval("UnitPrice") %>
                    </td>
                    <td>
                        <%# Eval("UnitsInStock") %>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <asp:Literal ID="Literal1" runat="server" Text="<%$ AppSettings:naynish %>" />
    </div>
    </form>
</body>
</html>
