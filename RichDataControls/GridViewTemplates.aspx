<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViewTemplates.aspx.cs"
    Inherits="GridViewTemplates" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="EmployeeDetailsDataUtility"
            SelectMethod="GetEmployees"
            UpdateMethod="UpdateEmployee"></asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="false"
            OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="Header">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" Text='<%# Eval("EmployeeID") %>' CommandName="Button_Click"
                            CommandArgument='<%# Eval("EmployeeID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FullName">
                    <ItemTemplate>
                        <%# Eval("FirstName") %>
                        <%# Eval("LastName") %>
                        <asp:Button ID="Button2" runat="server" Text='<%# Eval("EmployeeID") %>' CommandName="Edit" />
                        <asp:Button ID="Button3" runat="server" Text="Update" CommandName="Update" />
                    </ItemTemplate>
                </asp:TemplateField>               
            </Columns>
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
