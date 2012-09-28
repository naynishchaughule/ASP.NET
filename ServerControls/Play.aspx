<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Play.aspx.cs" Inherits="Play" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Button" ClientIDMode="AutoID" />
    </div>
    
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>       
    </asp:Panel>
    
    </form>
</body>
</html>
