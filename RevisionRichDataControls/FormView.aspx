<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormView.aspx.cs" Inherits="FormView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString='<%$ ConnectionStrings:connection %>' SelectCommand="select * from Products"
            UpdateCommand="Update Products set ProductName=@ProductName where ProductID=@ProductID">
        </asp:SqlDataSource>
        <asp:FormView ID="FormView1" runat="server" DataSourceID="SqlDataSource1">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox3" runat="server" Text='<%#  Bind("ProductID") %>' ReadOnly="true"></asp:TextBox>
                <asp:TextBox ID="TextBox4" runat="server" Text='<%#  Bind("ProductName") %>'></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Update" CommandName="Update" />
            </EditItemTemplate>
            <ItemTemplate>
                <asp:TextBox ID="TextBox2" runat="server" Text='<%#  Eval("ProductID") %>' ReadOnly="true"></asp:TextBox>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%#  Eval("ProductName") %>' ReadOnly="true"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Edit" CommandName="Edit" />
            </ItemTemplate>
        </asp:FormView>
    </div>
    </form>
</body>
</html>
