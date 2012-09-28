using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomValidatorDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CustomServerValidator(object sender, ServerValidateEventArgs args)
    {
        try
        {            
            args.IsValid = (int.Parse(args.Value) % 5 == 0);
        }
        catch
        {
            // An error is most likely caused by non-numeric data.
            args.IsValid = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        foreach (BaseValidator item in Page.Validators)
        {            
            Page.Response.Write(item.Enabled);            
        }
    }
}