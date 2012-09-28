<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidationGroup.aspx.cs"
    Inherits="ValidationGroup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server">
            <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="Group1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required!"
                ValidationGroup="Group1" ControlToValidate="TextBox1">*</asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" ValidationGroup="Group1" OnClick="Button1_Click"
                CausesValidation="false" />
        </asp:Panel>
    </div>
    <div>
        <asp:Panel ID="Panel2" runat="server">
            <asp:TextBox ID="TextBox2" runat="server" ValidationGroup="Group2"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required!"
                ValidationGroup="Group2" ControlToValidate="TextBox2">*</asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Button" ValidationGroup="Group2" 
                onclick="Button2_Click" CausesValidation="false" />
        </asp:Panel>
    </div>
    </form>
</body>
</html>
