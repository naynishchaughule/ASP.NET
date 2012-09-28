<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inline.aspx.cs" Inherits="Inline" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/C#" runat="server">
        protected new void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Inline Coding";
            //cntrl + shift + up/down
            Label2.Text = "today's date: ";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = DateTime.Now.ToLongDateString();
            Label2.Text += "  (" + x + ")";            
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
