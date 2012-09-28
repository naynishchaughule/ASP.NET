<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViewTemplates.aspx.cs"
    Inherits="GridViewTemplates" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="CustomerDataUtility"
            SelectMethod="GetAllCustomers"></asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="false"
            Caption="Customer Comments" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <img alt="Hello World!" src='<%# CustomerDataUtility.GetStatusPicture(Container.DataItem) %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <%# Eval("ID") %>
                        <asp:TextBox Text='<%# Bind("Comments") %>' runat="server" ID="textBox" TextMode="MultiLine"
                            Width="413px" />
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <b>
                            <%# Eval("ID") %></b>
                        <%# Eval("Comments") %>
                        <br />
                        <br />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Text="Like" Value="Verify"></asp:ListItem>
                            <asp:ListItem Text="DisLike" Value="Verify"></asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" CommandName="imgButton" CommandArgument='<%# Eval("ID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Submit" />
        </asp:PlaceHolder>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
