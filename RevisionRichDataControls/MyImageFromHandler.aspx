<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyImageFromHandler.aspx.cs" Inherits="MyImageFromHandler" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <img src="ImageFromDB.ashx?id=10" id="img1" alt="Logo" />        
    </div>
    </form>
</body>
</html>
