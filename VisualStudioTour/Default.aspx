<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position: absolute; left: 100px; top: 50px; width: 200px">
        <asp:TextBox ID="txtName" Text="naynish" ForeColor="Blue" runat="server" />
    </div>
    <div style="position: absolute; left: 100px; top: 100px; width: 200px">
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White"
            BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px"
            NextPrevFormat="FullMonth" Width="350px" OnSelectionChanged="Calendar1_SelectionChanged">
            <DayHeaderStyle Font-Bold="false" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="ControlDarkDark" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="ControlDark" />
            <SelectedDayStyle BackColor="ControlDark" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="2px" Font-Bold="false"
                Font-Size="10pt" ForeColor="ControlText" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
    </div>
    <div style="position: absolute; left: 100px; top: 300px; width: 200px">
        <input id="Text1" type="text" runat="server" />
    </div>
    </form>
</body>
</html>
