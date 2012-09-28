<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CompareValidator.aspx.cs" Inherits="CompareValidator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Button" /><br />
        <asp:CompareValidator Display="Dynamic" Operator="Equal" Type="String" ControlToValidate="TextBox2" ControlToCompare="TextBox1" ID="CompareValidator1" runat="server" ErrorMessage="not equal"><img src="firefox2005-icon.png" alt="The passwords don't match" /></asp:CompareValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" />
    </div>

    <div>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ControlToValidate="TextBox3" ValidationExpression=".*@.{2,}\..{2,}"
            ID="RegularExpressionValidator1" runat="server" ErrorMessage="not a valid email" Display="Dynamic">*</asp:RegularExpressionValidator>
    </div>
    </form>
</body>
</html>
