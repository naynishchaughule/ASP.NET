<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Decryption Key <asp:TextBox ID="txtDecryptionKey" runat="server"></asp:TextBox><br />
        Validation Key&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtValidationKey" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    </div>
    <div>
    <br />
        <asp:Button ID="Button2" runat="server" Text="Button" onclick="Button2_Click" />
    </div>
    </form>
</body>
</html>
