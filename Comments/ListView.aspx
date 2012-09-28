<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListView.aspx.cs" Inherits="ListView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="WikiCommentsDataUtility"
            SelectMethod="GetAllComments"></asp:ObjectDataSource>
        <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1" GroupItemCount="1">
            <LayoutTemplate>
                <table border="1">
                    <thead>
                        <tr>
                            <th>
                                UserID
                            </th>
                            <th>
                                UserComments
                            </th>
                        </tr>
                    </thead>
                    <tbody id="groupPlaceholder" runat="server">
                    </tbody>
                </table>
                <asp:DataPager runat="server" ID="ContactsDataPager" PageSize="6">
                    <Fields>
                        <asp:NextPreviousPagerField ShowFirstPageButton="true" ShowLastPageButton="true"
                            FirstPageText="|&lt;&lt; " LastPageText=" &gt;&gt;|" NextPageText=" &gt; " PreviousPageText=" &lt; " />
                    </Fields>
                </asp:DataPager>
            </LayoutTemplate>
            <GroupTemplate>
                <tr>
                    <td runat="server" id="itemPlaceholder" valign="top" />
            </GroupTemplate>
            <ItemTemplate>
                
                    <td>
                        <%# Eval("UserID") %>
                    </td>
                    <td>
                        <%# Eval("UserComments") %>
                    </td>
                
            </ItemTemplate>
        </asp:ListView>
    </div>
    </form>
</body>
</html>
