using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CacheItem
/// </summary>
[Serializable]
public class CacheItem
{
    public DateTime utcExpiry { get; set; }
    public object entry { get; set; }

	public CacheItem(DateTime utcExpiry, object entry)
	{
        this.utcExpiry = utcExpiry; this.entry = entry;
	}
}