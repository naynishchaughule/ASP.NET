using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataSet1TableAdapters;
using System.Data;
using System.Data.Linq;

public partial class DataBinding : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet1.CategoryDataTable Category = new DataSet1.CategoryDataTable();
        CategoryTableAdapter catAdap = new CategoryTableAdapter();

        DataSet1.ProductsDataTable Products = new DataSet1.ProductsDataTable();
        ProductsTableAdapter prodAdap = new ProductsTableAdapter();

        catAdap.Fill(Category);
        prodAdap.Fill(Products);

        var result = from item in Products
                     select item;

        DataTable queriedProducts = result.CopyToDataTable<DataSet1.ProductsRow>();
        queriedProducts.TableName = "queriedProducts";
        DataSet1 ds = new DataSet1();
        ds.Tables.Add(queriedProducts);
        //DataView view = result.AsDataView<DataSet1.ProductsRow>();
        //view.RowFilter = "CategoryID = 65985";
        GridView1.DataSource = ds.Tables["queriedProducts"];
        GridView1.DataBind();
    }
}