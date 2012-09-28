<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="WikiCommentsDataUtility"
            SelectMethod="GetAllComments" UpdateMethod="Update"></asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False"
            AutoGenerateEditButton="false" CellPadding="4" ForeColor="#333333" GridLines="None"
            Caption="Wiki Comments" ClientIDMode="Predictable" ClientIDRowSuffix="UserID">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <i>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("UserID") %>'></asp:Label><br />
                        </i>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("UserComments") %>' Width="500px"
                            Height="200px" TextMode="MultiLine"></asp:TextBox><br />
                        <%--<asp:Button ID="Button1" runat="server" Text="Edit" CommandName="Edit" />--%>
                        <asp:Button ID="Button2" runat="server" Text="Update" CommandName="Update" />
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
