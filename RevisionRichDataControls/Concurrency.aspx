<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Concurrency.aspx.cs" Inherits="Concurrency" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString='<%$ ConnectionStrings: connection %>' SelectCommand="select * from Products"
            UpdateCommand="update Products set ProductName=@ProductName, UnitPrice=@UnitPrice, UnitsInStock=@UnitsInStock
            where CategoryID=@org_CategoryID and ProductID=@org_ProductID and ProductName=@org_ProductName and UnitPrice=@org_UnitPrice and UnitsInStock=@org_UnitsInStock"
            ConflictDetection="CompareAllValues" OldValuesParameterFormatString="org_{0}">
            <UpdateParameters>
                <asp:Parameter Name="ProductName" />
                <asp:Parameter Name="UnitPrice" />
                <asp:Parameter Name="UnitsInStock" />
                <asp:Parameter Name="CategoryID" />
                <asp:Parameter Name="ProductID" />
                <asp:Parameter Name="org_CategoryID" />
                <asp:Parameter Name="org_ProductID" />
                <asp:Parameter Name="org_ProductName" />
                <asp:Parameter Name="org_UnitPrice" />
                <asp:Parameter Name="org_UnitsInStock" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" DataSourceID="SqlDataSource1"
            AllowPaging="true" AutoGenerateRows="false" OnItemUpdated="DetailsView1_ItemUpdated" DataKeyNames="ProductID">
            <Fields>
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" ReadOnly="true" />
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="true" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" />
                <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" />
                <asp:CommandField ShowEditButton="true" />
            </Fields>
        </asp:DetailsView>
    </div>
    <div>
        <asp:Panel ID="Panel1" runat="server" Visible="false" EnableViewState="false">
            There is a newer version of this record in the database.<br />
            The current record has the values shown below.<br />
            <br />
            Click <b>Update</b> to override these values with your changes.<br />
            Click <b>Cancel</b> to abandon your edit.</span>&nbsp;
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ProviderName="System.Data.SqlClient"
                ConnectionString='<%$ ConnectionStrings:connection %>' SelectCommand="select * from Products where ProductID=@ProductID"
                OnSelecting="SqlDataSource2_Selecting">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DetailsView1" Name="ProductID" PropertyName="SelectedValue"
                        Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:DetailsView ID="DetailsView2" runat="server" Height="50px" Width="125px" DataSourceID="SqlDataSource2">
            </asp:DetailsView>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
