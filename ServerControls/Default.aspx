<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function Display() {
            var displayText = document.getElementById("Text1");
            alert('Hello, ' + displayText.value);
            var myVar = document.getElementById("myDiv");
            myVar.innerHTML = "<b>Bold Text</b>";
            myVar.innerText = "<b>Bold Text</b>";
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input style="color: Red" id="Text1" type="text" /><br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="Display()" /><br />
        <p id="myDiv">
        </p>
        <input type="button" id="btnSubmit" value="Submit" runat="server" onserverclick="btnSubmit_Click" />
    </div>
    </form>
</body>
</html>
