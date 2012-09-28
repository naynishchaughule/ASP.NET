using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;
using DataSet1TableAdapters;

public partial class LinqToDataSet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Products";
        cmd.Connection = con;
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = cmd;
        DataSet dataSet = new DataSet();
        try
        {
            con.Open();
            adapter.Fill(dataSet, "Products");
            var result = from item in dataSet.Tables["Products"].AsEnumerable()
                         where item.Field<int>("ProductID") == 826388
                         select new { ProductName = item.Field<string>("ProductName"), UnitPrice = item.Field<decimal>("UnitPrice"), UnitsInStock = item.Field<int>("UnitsInStock") };
            GridView1.DataSource = result;
            GridView1.DataBind();
        }
        catch (Exception)
        {
            throw new ApplicationException("Data error");
        }
        finally
        {
            con.Close();
        }

        DataTable tab = new DataTable();
        tab.Columns.Add("FileName", typeof(string));
        tab.Columns.Add("FileSize", typeof(Int64));
        tab.Columns.Add("CreationTime", typeof(DateTime));

        DataRow row = null;

        DirectoryInfo dirInfo = new DirectoryInfo(@"C:\");
        foreach (var item in dirInfo.GetFiles())
        {
            row = tab.NewRow();
            row[0] = item.Name;
            row[1] = item.Length;
            row[2] = item.CreationTime;
            tab.Rows.Add(row);
        }

        var resultFiles = from item in tab.AsEnumerable()
                          where item.Field<Int64>("FileSize") > 10
                          select new { FileName = item.Field<string>("FileName"), FileSize = item.Field<Int64>("FileSize"), CreationTime = item.Field<DateTime>("CreationTime") };
        GridView2.DataSource = resultFiles;
        GridView2.DataBind();

        XDocument xmlFile = XDocument.Load(@"C:\test.xml");
        var resultXml = from item in xmlFile.Descendants("Product")
                        select new
                        {
                            ProductName = item.Element("ProductName").Value,
                            Cost = item.Element("Cost").Value
                        };
        DataTable table = new DataTable();
        table.Columns.Add("ProductName", typeof(string));
        table.Columns.Add("Cost", typeof(int));

        DataRow RowX = null;
        foreach (var item in resultXml)
        {
            RowX = table.NewRow();
            RowX[0] = item.ProductName;
            RowX[1] = item.Cost;
            table.Rows.Add(RowX);
        }

        var finalOut = from item in table.AsEnumerable()
                       where item.Field<int>("Cost") > 10
                       select new { ProductName = item.Field<string>("ProductName"), Cost = item.Field<int>("Cost") };

        GridView3.DataSource = finalOut;
        GridView3.DataBind();

        JoinQuery();
        StronglyTypedDataSet();
        DataViewDemo();
    }

    public void DataViewDemo()
    {
        DataSet1.CategoryDataTable Category = new DataSet1.CategoryDataTable();
        CategoryTableAdapter catAdap = new CategoryTableAdapter();
        catAdap.Fill(Category);

        DataSet1.ProductsDataTable Products = new DataSet1.ProductsDataTable();
        ProductsTableAdapter prodAdap = new ProductsTableAdapter();
        prodAdap.Fill(Products);

        var result = from item in Products
                     select item;
        DataView view = result.AsDataView();
        view.Sort = "ProductName desc";
        view.RowFilter = "CategoryID = 65985";        
        GridView7.DataSource = view;
        GridView7.DataBind();
        DataSet1.ProductsRow row = null;
        List<DataSet1.ProductsRow> myList = new List<DataSet1.ProductsRow>();
        foreach (DataRowView item in view)
        {
            row = (DataSet1.ProductsRow)item.Row;
            myList.Add(row);
        }
        GridView8.DataSource = myList;
        GridView8.DataBind();
    }

    public void StronglyTypedDataSet()
    {
        DataSet1.CategoryDataTable CategoryDT = new DataSet1.CategoryDataTable();
        CategoryTableAdapter CategoryTBAdapter = new CategoryTableAdapter();

        DataSet1.ProductsDataTable ProductsDT = new DataSet1.ProductsDataTable();        
        ProductsTableAdapter ProductsTBAdapter = new ProductsTableAdapter();

        CategoryTBAdapter.Fill(CategoryDT);
        ProductsTBAdapter.Fill(ProductsDT);

        var result = from cat in CategoryDT
                     join prod in ProductsDT
                     on cat.CategoryID equals prod.CategoryID
                     where cat.CategoryID == 65985
                     select new { CategoryName = cat.CategoryName, ProductName = prod.ProductName, UnitPrice = prod.UnitPrice };        

        GridView6.DataSource = result;
        GridView6.DataBind();
    }

    public void JoinQuery()
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Category";
        cmd.Connection = con;
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = cmd;
        SqlCommand cmd1 = new SqlCommand("select * from Products", con);        
        DataSet dataSet = new DataSet();
        try
        {
            con.Open();
            adapter.Fill(dataSet, "Category");
            adapter.SelectCommand = cmd1;
            adapter.Fill(dataSet, "Products");

        }
        catch (Exception)
        {
            throw new ApplicationException("JoinQuery error");
        }
        finally
        {
            con.Close();
        }
        var result = from cat in dataSet.Tables["Category"].AsEnumerable()
                     join prod in dataSet.Tables["Products"].AsEnumerable()
                     on cat.Field<int>("CategoryID") equals prod.Field<int>("CategoryID")
                     select new { CategoryName = cat.Field<string>("CategoryName"), ProductName = prod.Field<string>("ProductName") };
        GridView5.DataSource = result;
        GridView5.DataBind();                
    }
}