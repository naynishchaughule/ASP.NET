using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for Encrypt
/// </summary>
public class Encrypt
{
	public Encrypt()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static string CreateMachineKey(int length)
    {
        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        byte[] random = new byte[length/2]; 
        rng.GetBytes(random);
        StringBuilder machineKey = new StringBuilder(length);
        for (int i = 0; i < random.Length; i++)
        {
            machineKey.Append(String.Format("{0:X2}", random[i]));
        }
        return machineKey.ToString();
    }
}