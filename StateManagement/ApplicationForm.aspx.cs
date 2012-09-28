using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ApplicationForm : System.Web.UI.Page
{
    Dictionary<string, string> myDictionary;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        SaveData(Page.Controls);
        Label1.Text = "Saved";
    }

    protected void SaveData(ControlCollection controls)
    {
        myDictionary = new Dictionary<string, string>(); 
        foreach (Control item in controls)
        {
            if(item is TextBox)
            {
                myDictionary[item.ID] = ((TextBox)item).Text;
            }
            else if(item.HasControls())
            {
                SaveData(item.Controls);
            }
        }

        ViewState["formData"] = myDictionary;        
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        DisplayData(Page.Controls);
    }

    protected void DisplayData(ControlCollection controls)
    {        
        foreach (KeyValuePair<string, string> item in (Dictionary<string,string>)ViewState["formData"])
        {            
            Label1.Text += item.Value + " ";
        }
    }
}