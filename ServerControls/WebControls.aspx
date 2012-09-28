<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebControls.aspx.cs" Inherits="WebControls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="Button2">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Button" BackColor="ControlDark" />
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label" AccessKey="A" AssociatedControlID="TextBox2"></asp:Label><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
    </div>
    <asp:Panel runat="server" DefaultButton="btn" Height="26px" Width="278px" ScrollBars="Auto">
        <asp:TextBox runat="server" /><br />
        <asp:Button ID="btn" Text="text" runat="server" onclick="btn_Click" />
    </asp:Panel>
    </form>
</body>
</html>
