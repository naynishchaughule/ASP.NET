<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text='<%# x %>'></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text='<%$ AppSettings:employeeName %>'></asp:Label><br />
        <asp:Label ID="Label3" runat="server" Text='<%$ ConnectionStrings:nashNorthwind %>'></asp:Label><br />
        <asp:Label ID="Label4" runat="server" Text='<%$ RandomNumber:1,6 %>'></asp:Label>
    </div>
    </form>
</body>
</html>
