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
            ShowFooter="true" EnableSortingAndPagingCallbacks="false" 
            onrowcommand="GridView1_RowCommand" SelectedRowStyle-BackColor="Green" AutoGenerateEditButton="true">
            <Columns>
            <asp:CommandField ShowSelectButton="true" SelectText="select" ButtonType="Button" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button CommandName="EmployeeIDButton" CommandArgument='<%# Eval("EmployeeID") %>' ID="Button1" runat="server" Text='<%# Eval("EmployeeID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# EmployeeDetailsDataUtility.TravelRequest(Container.DataItem) %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderTemplate>
                        Status
                    </HeaderTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <%# Eval("EmployeeID","{0:C}") %>
                        <%# Eval("FirstName") %>
                        <%# Eval("LastName") %>
                        <i>
                            <%# ((EmployeeDetailsDataPackage)Container.DataItem).TitleOfCourtesy %>
                        </i>
                    </ItemTemplate>
                    <HeaderTemplate>
                        Employee Details
                    </HeaderTemplate>
                    <FooterTemplate>
                        <i>powered by nash</i>
                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
            <PagerTemplate>
            </PagerTemplate>
            <EmptyDataTemplate>
                <asp:Label ID="Label1" runat="server" Text="Database has no records"></asp:Label>
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
