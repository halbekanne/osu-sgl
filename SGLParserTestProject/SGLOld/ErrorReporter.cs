using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Net;
using System.IO;

namespace SGLOld
{
    public class ErrorReporter
    {

        private Exception exception;
        private String input;
        private String tree;

        public ErrorReporter(Exception exception, String input, String tree)
        {
            this.exception = exception;
            this.input = input;
            this.tree = tree;
        }

        public void DoWork()
        {
            ErrorReporter.SendErrorReport(exception, input, tree);
        }
        
        public static void SendErrorReport(Exception exception, String input, String tree) {

            String uid = getUID();
            if (uid.Equals("undefined"))
            {
                Console.WriteLine("Error report cannot be sent: missing MAC address.");
            }
            else
            {
                String parameters = "uid=" + uid + "&"
                                  + "message=" + exception.Message + "&"
                                  + "stacktrace=" + exception.StackTrace + "&"
                                  + "input=" + input + "&"
                                  + "tree=" + tree;
                String uri = @"http://www.osu-german.de/sglerror/";
                //Console.WriteLine("ok make http post: " + HttpPost(uri, parameters));

            }
        }

        public static String getUID()
        {
            try
            {
                ManagementScope theScope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\cimv2");
                StringBuilder theQueryBuilder = new StringBuilder();
                theQueryBuilder.Append("SELECT MACAddress FROM Win32_NetworkAdapter");
                ObjectQuery theQuery = new ObjectQuery(theQueryBuilder.ToString());
                ManagementObjectSearcher theSearcher = new ManagementObjectSearcher(theScope, theQuery);
                ManagementObjectCollection theCollectionOfResults = theSearcher.Get();

                foreach (ManagementObject theCurrentObject in theCollectionOfResults)
                {
                    if (theCurrentObject != null && theCurrentObject["MACAddress"] != null)
                    {
                        return theCurrentObject["MACAddress"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                return "undefined";
            }
            return "undefined";
        }






        private static string HttpPost(string uri, string parameters)
        {
            // parameters: name1=value1&name2=value2	
            WebRequest webRequest = WebRequest.Create(uri);
            //string ProxyString = 
            //   System.Configuration.ConfigurationManager.AppSettings
            //   [GetConfigKey("proxy")];
            //webRequest.Proxy = new WebProxy (ProxyString, true);
            //Commenting out above required change to App.Config
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.Method = "POST";
            byte[] bytes = Encoding.ASCII.GetBytes(parameters);
            Stream os = null;
            try
            { // send the Post
                webRequest.ContentLength = bytes.Length;   //Count bytes to send
                os = webRequest.GetRequestStream();
                os.Write(bytes, 0, bytes.Length);         //Send it
            }
            catch (WebException ex)
            {
                //Console.WriteLine("HttpPost: Request error");
            }
            finally
            {
                if (os != null)
                {
                    os.Close();
                }
            }

            try
            { // get the response
                WebResponse webResponse = webRequest.GetResponse();
                if (webResponse == null)
                { return null; }
                StreamReader sr = new StreamReader(webResponse.GetResponseStream());
                return sr.ReadToEnd().Trim();
            }
            catch (WebException ex)
            {
                Console.WriteLine("HttpPost: Response error");
            }
            return null;
        } // end HttpPost


    }
}
