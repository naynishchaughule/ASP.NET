using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Messaging;
using System.Threading;

/// <summary>
/// Summary description for HelperMessageQueueCacheDependency
/// </summary>
public class HelperMessageQueueCacheDependency : System.Web.Caching.CacheDependency
{
    private MessageQueue queue;
    public HelperMessageQueueCacheDependency(string queueName)
	{
        queue = new MessageQueue(queueName);
        ThreadPool.QueueUserWorkItem(new WaitCallback(WaitForMessage));
	}
    private void WaitForMessage(object state)
    {
        Message msg = queue.Receive();
        base.NotifyDependencyChanged(this, EventArgs.Empty);
    }
}