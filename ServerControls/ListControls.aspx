<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListControls.aspx.cs" Inherits="ListControls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
            <asp:ListItem>Finance</asp:ListItem>
            <asp:ListItem>Human Resource</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Naynish</asp:ListItem>
            <asp:ListItem>Tripti</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="3">
            <asp:ListItem>option1</asp:ListItem>
            <asp:ListItem>option2</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>DC</asp:ListItem>
            <asp:ListItem>NY</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button Text="Submit" ID="Submit" runat="server" OnClick="Submit_Click" />
    </div>
    </form>
</body>
</html>
