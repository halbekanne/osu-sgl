using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace SGL
{
    class ErrorReporter
    {
        
        public static void SendErrorReport(Exception exception, String input, String tree) {

            String uid = getUID();
            if (uid.Equals("undefined"))
            {
                Console.WriteLine("Error report cannot be sent: missing MAC address.");
            }
            else
            {



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


    }
}
