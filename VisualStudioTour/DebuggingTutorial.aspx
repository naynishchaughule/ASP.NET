<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DebuggingTutorial.aspx.cs"
    Inherits="DebuggingTutorial" EnableViewState="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position: absolute; left: 50px; top: 50px">
        <asp:Label ID="Label1" runat="server" Text="Label" /><br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
