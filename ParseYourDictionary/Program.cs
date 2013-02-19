using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;  
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
            
            //test2
            string word = "";
            int mode = 0;
            string tmpPath = "";
            Thread threadWriteCache = null;
 
            try
            {
                foreach (string str in args)
                {
                    if (str.Substring(0, 2) == "-d")
                    {
                        mode = 1;
                        continue;
                    }
                    else if (str.Substring(0, 2) == "-r")
                    {
                        mode = 2;
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
                    List<string> l;
                    bool bNeedToStore = false;
                    if (!YourDictionary.CheckCache(word, Application.UserAppDataPath))
                    {
                        st = YourDictionary.GetHTML(word, 'E');
                        l = YourDictionary.ParseExamples(st);

                        st = YourDictionary.GetHTML(word, 'D');
                        l.AddRange(YourDictionary.ParseExamplesD(st));

                        threadWriteCache = new Thread(delegate()
                        {
                            YourDictionary.StoreInCache(l, word, Application.UserAppDataPath);
                        });
                        threadWriteCache.Start();

                        
                    }
                    else
                    {
                        l = YourDictionary.GetFromCache(word, Application.UserAppDataPath);
                    }
                    st = YourDictionary.GetRandomExample(l);

                    Process ExternalProcess = new Process();
                    ExternalProcess.StartInfo.FileName = Application.StartupPath + "\\SayStatic.exe";
                    ExternalProcess.StartInfo.Arguments = st;
                    ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    ExternalProcess.Start();

                    tmpPath = Path.GetTempPath();
                    StreamWriter sw = File.CreateText(tmpPath + "tempText.txt");
                    sw.WriteLine(st);
                    sw.Close(); 

                    ExternalProcess.WaitForExit();
                    threadWriteCache.Join(10000); 

                }
                else if (mode == 2)
                {
                    string st = "";
                    tmpPath = Path.GetTempPath();
                    try
                    {
                        StreamReader sr = File.OpenText(tmpPath + "tempText.txt");
                        st = sr.ReadLine();
                        sr.Close();
                    }
                    catch
                    { }

                    frmSentence f = new frmSentence();
                    f.textBox1.Text = st;
                    f.ShowDialog();
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Form1 f = new Form1();
                    f.word = word;
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LogFile.WriteFile("Main:" + ex.ToString()  , LogLevel.Errors );
            }

          }


    }
}
