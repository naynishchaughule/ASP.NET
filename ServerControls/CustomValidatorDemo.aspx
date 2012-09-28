<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomValidatorDemo.aspx.cs"
    Inherits="CustomValidatorDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function CustomClientValidator(customValidatorReference, customArgumentObject) {
            customArgumentObject.IsValid = (customArgumentObject.Value % 5 == 0)
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" CausesValidation="true" OnClick="Button1_Click" />
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="not a multiple of 5"
            ControlToValidate="TextBox1" ClientValidationFunction="CustomClientValidator"
            OnServerValidate="CustomServerValidator" ValidateEmptyText="true"></asp:CustomValidator><br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Invalid"
            DisplayMode="List" />
    </div>
    </form>
</body>
</html>
