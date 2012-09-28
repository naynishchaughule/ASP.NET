using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.IO;

/// <summary>
/// Summary description for ImageProtectionSoftware
/// </summary>
public class ImageProtectionSoftware : IHttpHandler
{
	public ImageProtectionSoftware()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public bool IsReusable
    {
        get { return true; }
    }

    public void ProcessRequest(HttpContext context)
    {
        HttpResponse response = context.Response;
        HttpRequest request = context.Request;
        string imagePath = null;

        // Check whether the page requesting the image is from your site.
        if (request.UrlReferrer != null)
        {
            if ((String.Compare(request.Url.Host, request.UrlReferrer.Host, true, CultureInfo.InvariantCulture) == 0))
            {
                imagePath = request.PhysicalPath;
                if(!File.Exists(imagePath))
                {
                    response.Status = "File not found";
                    response.StatusCode = 404;
                    return;
                }
            }
        }

        if (imagePath == null)
        {
            // No valid image was allowed.
            // Return the warning image instead of the requested image.
            // Rather than hard-code this image, you could
            // retrieve it from the web.config file
            // (using the <appSettings> section or a custom
            // section).
            imagePath = context.Server.MapPath("./file_not_found.jpg");
        }

        // Set the content type to the appropriate image type.
        response.ContentType = "image/" + Path.GetExtension(imagePath).ToLower();

        // Serve the image.
        response.WriteFile(imagePath);
    }
}