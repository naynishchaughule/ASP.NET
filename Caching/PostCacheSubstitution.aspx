﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PostCacheSubstitution.aspx.cs"
    Inherits="PostCacheSubstitution" %>

<%@ OutputCache Duration="60" VaryByParam="none" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />
        <asp:Substitution ID="Substitution1" runat="server" MethodName="GetDynamicContent" />
    </div>
    </form>
</body>
</html>
