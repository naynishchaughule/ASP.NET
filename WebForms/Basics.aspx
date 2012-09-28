<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Basics.aspx.cs" Inherits="Basics" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <%--<form id="form1" runat="server">--%>
    <form method="post" action="Basics.aspx" runat="server">
    <div style="position: absolute; left: 100px; top: 50px">
        Name:
        <asp:TextBox ID="txtName" runat="server" />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <br />
        <asp:CheckBox ID="chbxEvent" runat="server" AutoPostBack="true" OnCheckedChanged="chbxEvent_Click" />
        <asp:Label ID="lblDisplay" runat="server" Text="Label" />
    </div>
    </form>
</body>
</html>
