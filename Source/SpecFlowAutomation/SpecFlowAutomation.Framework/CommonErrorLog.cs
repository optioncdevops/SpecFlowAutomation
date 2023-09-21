using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAutomation.Framework
{
    /// <summary>
    /// Summary description for ErrorLog
    /// </summary>
    public class CommonErrorLog : IDisposable
    {
        #region Properties

        private static string LogFilePath = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "\\ErrorLog", "\\", DateTime.Today.Year + "\\", DateTime.Today.Month);

        private string ErrorLogFileName = string.Empty;
        private string LogFileName = string.Empty;

        #endregion Properties

        public CommonErrorLog()
        {
            //check if the directory exists
            if (!Directory.Exists(LogFilePath))
            {
                Directory.CreateDirectory(LogFilePath);
            }
            ErrorLogFileName = string.Concat(LogFilePath, "\\", "ErrorLog_", DateTime.Today.ToShortDateString().Replace("/", "_"), ".log");
            LogFileName = string.Concat(LogFilePath, "\\", "Log_", DateTime.Today.ToShortDateString().Replace("/", "_"), ".log");

        }

        /// <summary>
        /// This method is to write the passed error message and other details of error occurence
        /// </summary>
        /// <param name="sMessage">string - Error message</param>
        ///
        public void WriteLog(string sMessage)
        {
            try
            {
                StreamWriter sw = File.AppendText(ErrorLogFileName);
                sw.WriteLine("Date/Time : " + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString());
                sw.WriteLine("Message   : " + sMessage);
                sw.Close();
            }
            catch (Exception ex)
            {
                string ErrMsg = ex.Message;
            }
        }


        public void WriteLog(Exception ex)
        {
            try
            {
                StreamWriter sw = File.AppendText(ErrorLogFileName);
                sw.WriteLine("-----------------------------------------------------------------------------------------");
                sw.WriteLine("Date/Time  :" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString());
                sw.WriteLine("Source/MSG :" + ex.Source + " / " + ex.Message);
                sw.WriteLine("StackTrace :" + ex.StackTrace);
                sw.WriteLine("-----------------------------------------------------------------------------------------");
                sw.Close();
            }
            catch (Exception exlog)
            {

            }
        }

        /// <summary>
        /// Method used to write the arugement to targetted text file in a new line
        /// </summary>
        /// <param name="sKey"> This key used to find the controls</param>
        /// <param name="sValues">Send the Values to the controls </param>
        /// <param name="sAction">Send the action that you need to performance</param>
        /// <param name="iLogMode">0 - Do not log the error in file   and 1 - Log the error in file  </param>
        public void WriteLog(string sKey, string sValues, string sAction, int iLogMode)
        {
            if (iLogMode == 1)
            {
                try
                {
                    StreamWriter sw = File.AppendText(LogFileName);
                    sw.WriteLine("-----------------------------------------------------------------------------------------");
                    sw.WriteLine("Date/Time  : " + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + "   Action : " + sAction == "" ? "Click" : sAction + "      sKey : " + sKey + "         sValues : " + sValues);
                    sw.Close();
                }
                catch (Exception ex)
                {

                }
            }

        }


        public void Dispose()
        {
            GC.Collect();
        }
    }


}
