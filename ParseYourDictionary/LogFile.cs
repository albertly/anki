// Instrumented
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ParseYourDictionary
{
    public enum LogLevel
    {
        None = 0,
        Errors = 1,
        Info = 2,
        Trace = 3

    }

    public class LogFile
    {
        
        public static string m_stLogPath = Path.GetTempPath()  + Application.ProductName + ".log";
        public static LogLevel m_iLogLevel = LogLevel.Trace;
        public static int m_iLogFileSize = 2000;

        public static void WriteFile(string input, LogLevel logLevel)
        {
            StreamWriter w = null;
            if (m_iLogLevel < logLevel)
            {
                return;
            }
 
            try
            {
                string fname = m_stLogPath;
                FileInfo finfo = new FileInfo(fname);

                if (finfo.Exists && finfo.Length > m_iLogFileSize * 1024)
                {
                    finfo.Delete();
                }

                FileStream fs = finfo.OpenWrite();
                w = new StreamWriter(fs);
                w.BaseStream.Seek(0, SeekOrigin.End);
                string stLogType = System.Enum.GetName(typeof(LogLevel), logLevel);
                w.Write("{0} {1}:{2}:{3}" + Environment.NewLine, DateTime.Now.ToLongTimeString() ,
                    DateTime.Now.ToShortDateString(), stLogType, input);

                w.Flush();

            }
            catch (Exception ex)
            {
            }
            finally
            {

                try
                {
                    if (w != null) w.Close();

                }
                catch (Exception ex1)
                {

                }

            }
        }

    }
}