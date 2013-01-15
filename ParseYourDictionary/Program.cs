using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
 
namespace ParseYourDictionary
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string word = "";
            int mode = 0;
            LogFile.WriteFile("Start 01", LogLevel.Info);

            try
            {
                foreach (string str in args)
                {
                    if (str.Substring(0, 2) == "-d")
                    {
                        mode = 1;
                        continue;
                    }
                    else
                    {
                        word = str;
                    }

                    break;

                }

                if (mode == 0)
                {
                    string st;
                    st = YourDictionary.GetHTML(word, 'E');
                    List<string> l = YourDictionary.ParseExamples(st);
                    st = YourDictionary.GetRandomExample(l);

                    Process ExternalProcess = new Process();
                    ExternalProcess.StartInfo.FileName = Application.StartupPath + "\\SayStatic.exe";
                    ExternalProcess.StartInfo.Arguments = st;
                    ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    ExternalProcess.Start();
                    ExternalProcess.WaitForExit();
                }
                else
                {
                    LogFile.WriteFile("Start 02", LogLevel.Info);
                    Form1 f = new Form1();
                    f.word = word;
                    LogFile.WriteFile("Start 03", LogLevel.Info);
                    f.ShowDialog();
                    LogFile.WriteFile("Start 04", LogLevel.Info);
                }
            }
            catch (Exception ex)
            {
                LogFile.WriteFile("Main:" + ex.ToString()  , LogLevel.Errors );
            }

          }


    }
}
