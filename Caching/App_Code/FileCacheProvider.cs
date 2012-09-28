using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.IO;
using System.Web.Configuration;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Specialized;

/// <summary>
/// Summary description for FileCacheProvider
/// </summary>
public class FileCacheProvider : OutputCacheProvider
{
    string CachePath;
    public override void Initialize(string name, NameValueCollection attributes)
	{
        base.Initialize(name, attributes);
        // Retrieve the web.config settings.
        CachePath = HttpContext.Current.Server.MapPath(attributes["cachePath"]);
	}

    public override object Add(string key, object entry, DateTime utcExpiry)
    {
        string path = ConvertKeyToPath(key);
        if(!File.Exists(path))
        {
            Set(key, entry, utcExpiry);
        }
        return entry;
    }

    public override void Set(string key, object entry, DateTime utcExpiry)
    {
        CacheItem item = new CacheItem(utcExpiry, entry);
        string path = ConvertKeyToPath(key);
        // Overwrite it, even if it already exists.
        using (FileStream file = File.OpenWrite(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, item);
        }
    }   

    public override object Get(string key)
    {
        string path = ConvertKeyToPath(key);
        if (!File.Exists(path)) return null;
        CacheItem item = null;
        using (FileStream file = File.OpenRead(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            item = (CacheItem)formatter.Deserialize(file);
        }
        // Remove expired items.
        if (item.utcExpiry <= DateTime.Now.ToUniversalTime())
        {
            Remove(key);
            return null;
        }
        return item.entry;
    }

    public override void Remove(string key)
    {
        string path = ConvertKeyToPath(key);
        if (File.Exists(path)) File.Delete(path);
    }
    
    private string ConvertKeyToPath(string key)
    {
        string file = key.Replace('/', '-');
        file += ".txt";
        //return Path.Combine(WebConfigurationManager.AppSettings["cachePath"], file);
        return Path.Combine(CachePath, file);
    }
}