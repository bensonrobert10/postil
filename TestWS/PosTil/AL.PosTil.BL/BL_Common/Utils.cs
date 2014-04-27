using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AL.PosTil.BL
{
    public sealed class Utils
    {

        public static bool WriteErrorLog(Exception exception)
        {
            try
            {
                string LogFilePath = System.Configuration.ConfigurationSettings.AppSettings["LogFilePath"];
                if (!Directory.Exists(LogFilePath))
                    Directory.CreateDirectory(LogFilePath);
                string DateString = System.DateTime.Now.ToString("dd-MMM-yyyy");
                WriteErrorLog(LogFilePath + "/Log" + DateString + ".log", exception);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool WriteErrorLog(string pathName, Exception exception)
        {
            bool bReturn = false;
            string strException = string.Empty;
            try
            {
                StreamWriter sw = new StreamWriter(pathName, true);
                sw.WriteLine("Source        : " +
                        exception.Source.ToString().Trim());
                sw.WriteLine("Method        : " +
                        exception.TargetSite.Name.ToString());
                sw.WriteLine("Date        : " +
                        DateTime.Now.ToLongTimeString());
                sw.WriteLine("Time        : " +
                        DateTime.Now.ToShortDateString());
                sw.WriteLine("Error        : " +
                        exception.Message.ToString().Trim());
                sw.WriteLine("Stack Trace    : " +
                        exception.StackTrace.ToString().Trim());
                sw.WriteLine("^^-------------------------------------------------------------------^^");
                sw.Flush();
                sw.Close();
                bReturn = true;
            }
            catch (Exception)
            {
                bReturn = false;
            }
            return bReturn;
        }

        #region Classes
        /// <summary>
        /// represents the postil status object
        /// </summary>
        public class PosTilStatus
        {
            private string _Message;
            private PosTilStatusType _Status;

            public string Message
            {
                get { return _Message; }
                set { _Message = value; }
            }
            public PosTilStatusType Status
            {
                get { return _Status; }
                set { _Status = value; }
            }
        }
        #endregion Classes

        #region Enums
        public enum PosTilStatusType
        {
            /// <summary>
            /// represents the operation has been successfully completed
            /// </summary>
            Success,

            /// <summary>
            /// represents the operation not found
            /// </summary>
            NotFound,

            /// <summary>
            /// represents the operation has been failed
            /// </summary>
            Error,

            /// <summary>
            /// represents the operation has been successfully done with some warnings
            /// </summary>
            Warning
        }
        #endregion Enums

    }
}
