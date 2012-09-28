using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Messaging;

public partial class MessageQueueCacheDependencyDemo : System.Web.UI.Page
{
    private string queueName = @".\Private$\TestQueue";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            MessageQueue queue;
            if (MessageQueue.Exists(queueName))
            {
                queue = new MessageQueue(queueName);
            }
            else
            {
                queue = MessageQueue.Create(@".\Private$\TestQueue");
            }
            lblInfo.Text += "Creating dependent item...<br />";
            Cache.Remove("Item");
            HelperMessageQueueCacheDependency dependency = new
            HelperMessageQueueCacheDependency(queueName);
            string item = "Dependent cached item";
            lblInfo.Text += "Adding dependent item<br />";
            Cache.Insert("Item", item, dependency);
        }
    }
    protected void cmdModify_Click(object sender, EventArgs e)
    {
        MessageQueue queue = new MessageQueue(queueName);
        // (You could send a custom object instead
        // of a string.)
        queue.Send("Invalidate!");
        lblInfo.Text += "Message sent<br />";
    }
}