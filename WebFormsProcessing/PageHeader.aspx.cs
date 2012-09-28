using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class PageHeader : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Header.Title = "Page Header Demo";
        HtmlMeta metaTag = new HtmlMeta();
        metaTag.Name = "money";
        metaTag.Content = "no indexing";
        Page.Header.Controls.Add(metaTag);

        Button btnSubmit = new Button();
        btnSubmit.Text = "Submit";
        btnSubmit.Click += new EventHandler(btnSubmit_Click);
        Panel1.Controls.Add(btnSubmit);

        Button btnRemove = new Button();
        btnRemove.Text = "Remove";
        btnRemove.ID = "btnRemove";
        PlaceHolder1.Controls.Add(btnRemove);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //Button btn = (Button)Page.FindControl("btnRemove");
        //btn.Parent.Controls.Remove(btn);
        Page.FindControl("btnRemove").Parent.Controls.Remove(Page.FindControl("btnRemove"));
    }
}