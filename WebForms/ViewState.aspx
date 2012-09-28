<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewState.aspx.cs" Inherits="ViewState" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Naynish P. Chaughule"></asp:Label>
        <asp:CheckBox ID="CheckBox1" AutoPostBack="true" runat="server" /><br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="View State" OnClick="Button1_Click" /><br />
        <asp:Label ID="Label2" runat="server" Text="Label" EnableViewState="false"></asp:Label>
    </div>
    <div>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label" EnableViewState="false"></asp:Label><br />
        <asp:Button ID="Button2" runat="server" Text="Button 2" OnClick="Button2_Click" /><br />
        <asp:Button ID="Button3" runat="server" Text="Button 3" OnClick="Button3_Click" />
    </div>
    </form>
</body>
</html>
