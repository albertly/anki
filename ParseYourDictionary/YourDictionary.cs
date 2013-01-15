using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Security.Cryptography;

namespace ParseYourDictionary
{
    class YourDictionary
    {

        public static String GetHTML(string word, char mode)
        {
            string urlString = "";

            if (mode == 'E')
            {
                urlString = @"http://sentence.yourdictionary.com/" + word;
            }

            string htmlCode = "";
            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {                
                htmlCode = client.DownloadString(urlString);
            }

            return htmlCode;
        }

        public static List<string> ParseExamples(string stHTML)
        {
            List<string> examples = new List<string>();
            int index = 0;
            int endIndex = 0;
            index = stHTML.IndexOf("<ul class=\"example\">");
            endIndex = stHTML.IndexOf("</ul>");

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
            byte[] box = new byte[1];
            provider.GetBytes(box);

            int index = 0;

            index = (int)(Math.Round((examples.Count-1) * ((double)box[0] / Byte.MaxValue)));

            return examples[index];
        }
    }
}
