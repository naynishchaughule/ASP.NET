<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidationControls.aspx.cs"
    Inherits="ValidationControls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            ControlToValidate="TextBox1" ID="RequiredFieldValidator1" runat="server" ErrorMessage="required"
            EnableClientScript="true" Enabled="true">*</asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RangeValidator Type="Integer" MinimumValue="10" MaximumValue="30" ControlToValidate="TextBox2" ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator">*</asp:RangeValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" CausesValidation="true" OnClick="Button1_Click" /><br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowSummary="true"
            DisplayMode="List" />
    </div>
    </form>
</body>
</html>
