<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Params.aspx.cs" Inherits="Params" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString="<%$ ConnectionStrings: nashNorthwind %>" DataSourceMode="DataSet"
            SelectCommand="select * from Categories"></asp:SqlDataSource>
        <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="CategoryID" AutoPostBack="true">
        </asp:ListBox>
        <asp:Button ID="Button1" runat="server" Text="Get Products" /><br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString="<%$ ConnectionStrings: nashNorthwind %>" DataSourceMode="DataSet"
            SelectCommand="select * from Products where CategoryID=@CategoryID">
            <SelectParameters>
                <asp:ControlParameter Name="CategoryID" ControlID="ListBox1" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:ListBox ID="ListBox2" runat="server" DataSourceID="SqlDataSource2" DataTextField="ProductName"
            DataValueField="CategoryID"></asp:ListBox>
    </div>
    </form>
</body>
</html>
