<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Identity.aspx.cs" Inherits="Identity" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="EmployeeDetailsDataUtility"
            DataObjectTypeName="EmployeeDetailsDataUtility" SelectMethod="GetEmployees" DeleteMethod="DeleteEmployees"
            InsertMethod="InsertEmployee" OnInserted="ObjectDataSource1_Inserted">
            <InsertParameters>
                <asp:Parameter Direction="ReturnValue" Name="EmployeeID" Type="Int32" />
            </InsertParameters>
        </asp:ObjectDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" DataSourceID="ObjectDataSource1"
            AutoGenerateInsertButton="true" DefaultMode="Insert">
        </asp:DetailsView>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
