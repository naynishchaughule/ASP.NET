﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ObjectSourceMethodParams.aspx.cs"
    Inherits="ObjectSourceMethodParams" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="EmployeeDetailsDataUtility"
            SelectMethod="GetEmployees"></asp:ObjectDataSource>
        <asp:ListBox ID="ListBox1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="FirstName"
            DataValueField="EmployeeID" AutoPostBack="true"></asp:ListBox>
        
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" TypeName="EmployeeDetailsDataUtility"
            SelectMethod="GetEmployee">
            <SelectParameters>
                <asp:ControlParameter ControlID="ListBox1" Name="EmployeeID" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" DataSourceID="ObjectDataSource2">
        </asp:DetailsView>
    </div>
    </form>
</body>
</html>
