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
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="ProductsDataUtility"
            SelectMethod="Products_GetAllRecords" UpdateMethod="Products_UpdateProductName">
        </asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False"
            CellPadding="4" ForeColor="#333333" GridLines="None" Caption="Item Template"
            OnRowCommand="GridView1_RowCommand">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# GetImage(Container.DataItem) %>'
                            CommandName="ImageButtonClickEvent" CommandArgument='<%# Eval("ProductID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <i>CategoryID:</i> <b>
                            <%# Eval("CategoryID") %><br />
                        </b><i>ProductID:</i> <b>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ProductID") %>' ReadOnly="true"></asp:TextBox><br />
                        </b><i>UnitPrice:</i> <b>
                            <%# Eval("UnitPrice") %><br />
                        </b><i>UnitsInStock:</i> <b>
                            <%# ((ProductsDataPackage)Container.DataItem).UnitsInStock %><br />
                        </b></b><i>ProductName:</i> <b>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ProductName") %>'></asp:TextBox><br />
                            <asp:Button ID="Button1" runat="server" Text="Update" CommandName="Update" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSource='<%# Friends %>' SelectedIndex='<%# GetSelectedTitle(Eval("ProductID")) %>'>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
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
    </div>
    </form>
</body>
</html>
