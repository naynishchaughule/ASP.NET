using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class WebControls : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Button1.BorderWidth = Unit.Pixel(20);
        Unit uid = new Unit(10, UnitType.Pixel);
        Button1.BorderWidth = uid;
        //Button1.BackColor = Color.FromArgb(255, 0, 255, 0);
        //Button1.BackColor = Color.Beige;
        //Button1.BackColor = ColorTranslator.FromHtml("blue");
        Button1.Font.Size = FontUnit.Medium;
        Button1.Font.Name = "Arial";
        Button1.Font.Bold = false;
        Button1.Text = "Submit";
        TextBox1.Focus();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Page.Response.Write("Button2_Click default");
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        Page.Response.Write("btn_Click");
    }
}