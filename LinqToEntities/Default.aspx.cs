using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Objects;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NorthwindModel.NorthwindEntities objContext = new NorthwindModel.NorthwindEntities();
        //var result = from item in objContext.Categories
        //             where item.CategoryID == 65985
        //             select item;
        //outer join
        var result = from cat in objContext.Categories
                     join prod in objContext.Products
                     on cat.CategoryID equals prod.CategoryID
                     into groupedItems
                     //group cat by cat.CategoryID into groupedItems                     
                     select new { CategoryID = cat.CategoryID };

        GridView1.DataSource = result;
        GridView1.DataBind();
        Label1.Text = ((ObjectQuery)result).ToTraceString();
    }
}