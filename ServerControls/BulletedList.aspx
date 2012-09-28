<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BulletedList.aspx.cs" Inherits="BulletedList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:BulletedList ID="BulletedList1" runat="server" DisplayMode="LinkButton" 
            onclick="BulletedList1_Click">
            <asp:ListItem>Program 1</asp:ListItem>
            <asp:ListItem>Pascal Triangle</asp:ListItem>
        </asp:BulletedList>
    </div>
    <div>
    <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
