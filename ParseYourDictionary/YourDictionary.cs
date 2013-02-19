using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace ParseYourDictionary
{
    class YourDictionary
    {
        const string HTML_TAG_PATTERN = "<.*?>";

        public static bool CheckCache(string word, string path)
        {
            return File.Exists(path + "\\" + word.Substring(0, 2) + "\\" + word + ".bin");
        }
        public static String GetHTML(string word, char mode)
        {
            
            string urlString = "";

            if (mode == 'E')
            {
                urlString = @"http://sentence.yourdictionary.com/" + word;

            }
            else if (mode == 'D')
            {
                urlString = @"http://www.reference.com/example-sentences/" + word;
            }

            string htmlCode = "";
            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {                
                htmlCode = client.DownloadString(urlString);
            }

            return htmlCode;
        }

        public static void StoreInCache(List<string> examples, string word, string path)
        {
            try
            {
                Directory.CreateDirectory(path + "\\" + word.Substring(0, 2));
                using (Stream stream = File.Open(path + "\\" + word.Substring(0, 2) + "\\" + word + ".bin",  FileMode.CreateNew ))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, examples);
                }
            }
            catch (IOException ex)
            {
                object ex1 = ex;
            }

        }

        public static List<string> GetFromCache( string word, string path)
        {
            List<string> l = null;
            try
            {
                using (Stream stream = File.Open(path + "\\" + word.Substring(0, 2) + "\\" + word + ".bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    l = (List<string>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
            }

            return l;
        }


        public static List<string> ParseExamplesD(string stHTML)
        {
            List<string> examples = new List<string>();
            int index = 0;
            int endIndex = 0;
            string st1 = @"<div class=""example example_show"">";
            string st2 = @"<div class=""example example_hide"">";
            int lenSeparator = st1.Length;
            int lenEndSeparator = "</div>".Length; 
            index = IndexOfAny(stHTML,index,st1, st2);
            endIndex = stHTML.IndexOf(@"<div id=""sentence_examples_more"">", index);

            while (index != -1)
            {
                string st;
                int endIndexTmp = 0;
                
                endIndexTmp = stHTML.IndexOf("</div>", index);

                st = stHTML.Substring(index + lenSeparator, endIndexTmp - index - lenSeparator);
                st = StripHTML(st);
                examples.Add(st);
                index = IndexOfAny(stHTML, endIndexTmp, st1, st2);
            }

            return examples;
        }



        static int IndexOfAny(string inputString, int start, string s1, string s2)
        {
            int i = -1;

            i = inputString.IndexOf(s1, start);
            if (i == -1)
            {
                i = inputString.IndexOf(s2, start);
            }

            return i;
        }
        static string StripHTML (string inputString)
        {
           return Regex.Replace 
             (inputString, HTML_TAG_PATTERN, string.Empty);
        }
        public static List<string> ParseExamples(string stHTML)
        {
            List<string> examples = new List<string>();
            int index = 0;
            int endIndex = 0;
            index = stHTML.IndexOf("<ul class=\"example\">");
            endIndex = stHTML.IndexOf("</ul>",index);

            while (index < endIndex-5)
            {
                string st;
                int endIndexTmp = 0;
                index = stHTML.IndexOf("<li>", index);
                endIndexTmp = stHTML.IndexOf("</li>", index);

                st = stHTML.Substring(index + 4, endIndexTmp - index - 4);
                st = st.Replace("<strong>", "").Replace("</strong>", "").Replace("\n", " ");
                examples.Add(st);
                index = endIndexTmp + 5;
            }
            
            return examples;
        }


        static readonly int BufferSize = 16384;
        static readonly int NumFallback = 16384;
        static readonly int RetrieveTrigger = 4096;
        public static string GetRandomExample(List<string> examples)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            byte[] box = new byte[4];
            provider.GetBytes(box);
            UInt32 rngNum = BitConverter.ToUInt32(box, 0);
            int index = 0;

            index = (int)(Math.Round((examples.Count - 1) * ((double)rngNum / UInt32.MaxValue)));

            return examples[index];
        }
    }
}
