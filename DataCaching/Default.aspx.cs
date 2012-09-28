using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class _Default : System.Web.UI.Page
{
    ProductsDataUtility pDatautil;
    protected void Page_Load(object sender, EventArgs e)
    {
        pDatautil = new ProductsDataUtility();
        //Cache["Products"] = pDatautil.Products_GetAllRecords();
        //Cache.Insert("Products", pDatautil.Products_GetAllRecords(),null,DateTime.MaxValue,TimeSpan.FromMinutes(10));
        Cache.Insert("Products", pDatautil.Products_GetAllRecords(), null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);
        
        GridView1.DataSource = GetProducts();
        GridView1.DataBind();        
    }
    protected List<ProductsDataPackage> GetProducts()
    {
        List<ProductsDataPackage> list = (List<ProductsDataPackage>)Cache["Products"];
        if(list == null)
        {
            Cache.Insert("Products", pDatautil.Products_GetAllRecords(), null, DateTime.Now.AddMinutes(60), TimeSpan.Zero);
            return (List<ProductsDataPackage>)Cache["Products"];
        }
        return (List<ProductsDataPackage>)Cache["Products"];
    }
    protected void RemoveFromCache(string key)
    {
        foreach (DictionaryEntry item in Cache)
        {
            if(item.Key == "Products")
            {
                Cache.Remove(key);
            }
        }
    }
}