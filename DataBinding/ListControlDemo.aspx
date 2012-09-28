<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListControlDemo.aspx.cs"
    Inherits="ListControlDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" /><br />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Key" DataValueField="Value">
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Label" EnableViewState="false"></asp:Label><br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
