<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Event.aspx.cs" Inherits="Event" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <select id="Select1" multiple="true" runat="server" onserverchange="Select1_ServerChange">
            <option>checkout</option>
            <option>Add to Cart</option>
        </select><br />
        <input id="Text1" type="text" runat="server" onserverchange="Ctrl_ServerChange" /><br />
        <input id="Checkbox1" type="checkbox" runat="server" onserverchange="Ctrl_ServerChange" /><br />
        <input id="Submit1" type="submit" value="submit" runat="server" onserverclick="Submit1_ServerClick" />
    </div>
    </form>
</body>
</html>
