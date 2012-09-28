<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Editing.aspx.cs" Inherits="Editing" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="sourceProducts" runat="server" ConnectionString="<%$ ConnectionStrings:connection %>"
            ProviderName="System.Data.SqlClient" SelectCommand="SELECT ProductID,
            ProductName, Products.CategoryID, CategoryName, UnitPrice, UnitsInStock FROM Products
            INNER JOIN Category ON Products.CategoryID=Category.CategoryID" UpdateCommand="UPDATE Products SET ProductName=@ProductName,
            CategoryID=@CategoryID, UnitPrice=@UnitPrice WHERE ProductID=@ProductID"></asp:SqlDataSource>
        <asp:SqlDataSource ID="sourceCategory" runat="server" ConnectionString="<%$ ConnectionStrings:connection %>"
            ProviderName="System.Data.SqlClient" SelectCommand="SELECT CategoryName,CategoryID FROM Category">
        </asp:SqlDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" DataSourceID="sourceProducts"
            AllowPaging="true" AutoGenerateRows="false" AutoGenerateEditButton="true">
            <Fields>
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" />                
                <asp:TemplateField>                    
                    <ItemTemplate>
                        <%# Eval("CategoryName") %>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:DropDownList ID="lstCategories" runat="server" DataSourceID="sourceCategory"
                            DataTextField="CategoryName" DataValueField="CategoryID" SelectedValue='<%# Bind("CategoryID")%>'>
                        </asp:DropDownList>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" />
                <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" />
            </Fields>
        </asp:DetailsView>
    </div>
    </form>
</body>
</html>
