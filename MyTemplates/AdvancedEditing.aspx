<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdvancedEditing.aspx.cs"
    Inherits="AdvancedEditing" %>

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
            AutoGenerateEditButton="true">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <%#Eval("EmployeeID")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%#Bind("EmployeeID")%>'></asp:TextBox><br />
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%#Bind("FirstName")%>'></asp:TextBox><br />
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%#Bind("LastName")%>'></asp:TextBox><br />
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%#Bind("TitleOfCourtesy")%>'></asp:TextBox><br />
                        <asp:DropDownList runat="server" ID="EditTitle" SelectedIndex='<%# GetSelectedTitle(Eval("TitleOfCourtesy")) %>'
                            DataSource='<%# TitlesOfCourtesy %>' />
                    </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
