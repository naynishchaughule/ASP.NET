<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewStateDemo.aspx.cs" Inherits="ViewStateDemo"
    ViewStateMode="Disabled" ViewStateEncryptionMode ="Auto"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Label" EnableViewState="true" ViewStateMode="Enabled"></asp:Label><br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        </asp:Panel>
    </div>
    </form>
</body>
</html>
