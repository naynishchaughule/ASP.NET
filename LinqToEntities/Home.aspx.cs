using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NorthwindModel;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //NorthwindEntities objectContext = new NorthwindEntities();
        ////inner join
        //var result = from cat in objectContext.Categories
        //             join prod in objectContext.Products
        //             on cat.CategoryID equals prod.CategoryID
        //             group cat by cat.CategoryID into groupedCategories
        //             select new { CategoryID = groupedCategories.Key };
        
        //GridView1.DataSource = result;
        //GridView1.DataBind();

        ////outer join
        //var result1 = from cat in objectContext.Categories
        //             join prod in objectContext.Products
        //             on cat.CategoryID equals prod.CategoryID
        //             into groupedCategories
        //             select new { CategoryID = cat.CategoryID };
        //GridView2.DataSource = result1;
        //GridView2.DataBind();

        //var result2 = objectContext.Categories.Where((item) => (item.CategoryID == 287389)).Select((item) => (item)).First();
        //result2.CategoryName = "mumbai";        
        //objectContext.Categories.AddObject( new Category() { CategoryID = 876221, CategoryName = "India" });
        //objectContext.SaveChanges();

        //var result3 = objectContext.Categories.First<Category>((cat) => (cat.CategoryID == 65985));
        //result3.CategoryName = "london";
        //objectContext.SaveChanges();

        //var result4 = objectContext.Categories.First<Category>((cat) => (cat.CategoryID == 876221));
        //objectContext.DeleteObject(result4);
        //objectContext.SaveChanges();

        //var result5 = objectContext.Categories.Where((cat) => (cat.CategoryID == 287389)).First<Category>();
        //Product prod1 = new Product() { CategoryID = result5.CategoryID, ProductID = 72561, ProductName = "film", UnitPrice = 56, UnitsInStock = 132, Category = result5 };
        //objectContext.Products.AddObject(prod1);
        //objectContext.SaveChanges();

        NorthwindEntities end1 = new NorthwindEntities();
        var result6 = from item in end1.Products
                      select item;
        GridView1.DataSource = result6;
        GridView1.DataBind();

        var result7 = from cat in end1.Categories
                      join prod in end1.Products
                      on cat.CategoryID equals prod.CategoryID
                      select new { CategoryName = cat.CategoryName, ProductName = prod.ProductName };

        GridView1.DataSource = result7;
        GridView1.DataBind();

        var result8 = end1.Categories.Where<Category>((cat) => (cat.CategoryID == 287389)).First<Category>();
        result8.CategoryName = "paris";
        end1.SaveChanges();
    }
}