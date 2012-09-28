<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CrossPage1.aspx.cs" Inherits="CrossPage1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CrossPage1</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" PostBackUrl="~/CrossPage2.aspx" />
    </div>
    </form>
</body>
</html>
