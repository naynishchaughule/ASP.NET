<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditItemTemplate.aspx.cs"
    Inherits="EditItemTemplate" %>

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
                        <%# Eval("EmployeeID") %>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("FirstName") %>' TextMode="MultiLine"
                            Width="413px"></asp:TextBox>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("LastName") %>' TextMode="MultiLine"
                            Width="413px"></asp:TextBox>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("TitleOfCourtesy") %>' TextMode="MultiLine"
                            Width="413px"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
