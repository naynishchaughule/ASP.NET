<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FirstApp.aspx.cs" Inherits="FirstApp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <br />
    </div>
    <div>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="Handler" AutoPostBack="true"></asp:TextBox><br />
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="Handler" AutoPostBack="true" /><br />
        <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="Handler" AutoPostBack="true" />
    </div>
    <div>
        <br />
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" OnClick="Handler_Image" />
    </div>
    </form>
</body>
</html>
