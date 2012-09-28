using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;

/// <summary>
/// Summary description for TimerTestCacheDependency
/// </summary>
public class TimerTestCacheDependency : System.Web.Caching.CacheDependency
{
    private Timer timer;
    int resource = 0;
	public TimerTestCacheDependency() 
	{
        //create a timer that will check the resource every 5 seconds
        timer = new Timer(new TimerCallback(CheckResource),this,0,5000);
	}

    public void CheckResource(object sender)
    {
        //check your resource here
       if(resource > 4)
       {
           base.NotifyDependencyChanged(this, EventArgs.Empty);
           timer.Dispose();
       }
       resource++;
    }

    protected override void DependencyDispose()
    {
        // Cleanup code goes here.
        if (timer != null) timer.Dispose();
    }
}