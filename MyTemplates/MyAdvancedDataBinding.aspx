<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyAdvancedDataBinding.aspx.cs"
    Inherits="MyAdvancedDataBinding" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="EmployeeDetailsDataUtility"
            SelectMethod="GetEmployees" UpdateMethod="UpdateEmployee"></asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="false"
            OnRowUpdating="GridView1_RowUpdating" AutoGenerateEditButton="true">
            <Columns>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text=' <%#Bind("EmployeeID")%>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" SelectedIndex='<%# GetSelectedTitle(Eval("TitleOfCourtesy")) %>'
                            DataSource='<%#Prefix%>'>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <%#Eval("FirstName")%>
                        <%#Eval("LastName")%>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
