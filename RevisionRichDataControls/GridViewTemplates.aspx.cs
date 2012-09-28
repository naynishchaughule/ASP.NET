using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GridViewTemplates : System.Web.UI.Page
{
    public int[] Friends = new int[] { 601222, 651284, 672824 };

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected string GetImage(object dataItem)
    {
        int CategoryID = (int)DataBinder.Eval(dataItem, "CategoryID");
        if (CategoryID == 48090)
        {
            return "Beverage.jpg";
        }
        else
        {
            return "Condiments.jpg";
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //event bubbling
        if(e.CommandName == "ImageButtonClickEvent")
        {
            int productID = Convert.ToInt32(e.CommandArgument);
            if (productID == 601222)
                Page.Response.Write(productID);
        }
    }
    protected int GetSelectedTitle(object productID)
    {
        return Array.IndexOf(Friends, productID);
    }
}