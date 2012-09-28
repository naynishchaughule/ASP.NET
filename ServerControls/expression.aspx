<%@ Page Language="C#" AutoEventWireup="true" CodeFile="expression.aspx.cs" Inherits="expression" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ValidationExpression="[A-Z]+[a-z]*([0-9]{1,})+[a-z]*([0-9]{1,})+"
            ID="RegularExpressionValidator1" ControlToValidate="TextBox1" runat="server"
            ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
    </div>
    </form>
</body>
</html>
