using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;
using System.Drawing;

namespace CrossText.Service
{
    public static class Helper
    {

        public static bool CheckIfURLExists(Uri url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "HEAD";
                request.Credentials = CredentialCache.DefaultNetworkCredentials;

                if (request.GetResponse().ResponseUri.ToString().Contains("http://www.teletext.ch/notfound_d.php"))
                {
                  return false;
                }
                else
                { 
                  return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static byte[] GetImageFromURL(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Stream stream = httpWebReponse.GetResponseStream();

            // Convert from Stream to Image
            Image img = Image.FromStream(stream);

            // Get the Byte Array
            return imageToByteArray(img);
        }

        private static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        private static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


    }
}