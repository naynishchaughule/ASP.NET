using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CompletedSyncResult
/// </summary>
public class CompletedSyncResult : IAsyncResult
{
    private Exception operationException;
    public Exception OperationException
    {
        get { return operationException; }
        set { operationException = value; }
    }

    private object state;
    public object State { get; set; }

    public CompletedSyncResult(Exception operationException, AsyncCallback asyncCallback, object asyncState) 
	{
        State = asyncState;
        OperationException = operationException;
        // Code that triggers the callback, if it's used.
        if (asyncCallback != null)
        {
            asyncCallback(this);
        }
	}

    public object AsyncState
    {
        get { return State; }
    }

    public System.Threading.WaitHandle AsyncWaitHandle
    {
        get { return null; }
    }

    public bool CompletedSynchronously
    {
        get { return true; }
    }

    public bool IsCompleted
    {
        get { return true; }
    }
}