﻿using System.IO;
using System.Net;
using System.Text;

namespace Toci.Hornets.Legnica.Michał_Zembik.FTPcs
{
    public class SendFile
    {
        public bool Send(string sourcefilepath, string desinationfilepath, string login, string pass)
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(desinationfilepath);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential(login, pass);

            // Copy the contents of the file to the request stream.
            StreamReader sourceStream = new StreamReader(sourcefilepath);
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            sourceStream.Close();
            request.ContentLength = fileContents.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            response.Close();

            return true;
        }
    }
}
