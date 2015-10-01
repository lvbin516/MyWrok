using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using SearchEngin;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void TestMain()
        {
            FileStream fs = new FileStream("result.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

            sw.WriteLine("Google:");
            SearchEnginBase google = new GoogleEngin();
            List<SearchTerm> result0 = google.SearchKeyWordByTerm("iphone");
            if (result0 == null || result0.Count == 0)
            {
                sw.WriteLine("search result is empty!");
            }
            else
            {
                foreach (SearchTerm s in result0)
                {
                    sw.WriteLine(s.Term + "::  " + s.Keyword);
                }
            }
            sw.WriteLine("============================");


            sw.WriteLine("Bing:");
            SearchEnginBase bing = new BingEngin();
            List<SearchTerm> result1 = bing.SearchKeyWordByTerm("iphone");
            if (result1 == null || result1.Count == 0)
            {
                sw.WriteLine("search result is empty!");
            }
            else
            {
                foreach (SearchTerm s in result1)
                {
                    sw.WriteLine(s.Term + "::  " + s.Keyword);
                }
            }
            sw.WriteLine("============================");



            sw.WriteLine("Yahoo:");
            SearchEnginBase yahoo = new YahooEngin();
            List<SearchTerm> result2 = yahoo.SearchKeyWordByTerm("iphone");
            if (result2 == null || result2.Count == 0)
            {
                sw.WriteLine("search result is empty!");
            }
            else
            {
                foreach (SearchTerm s in result2)
                {
                    sw.WriteLine(s.Term + "::  " + s.Keyword);
                }
            }
            sw.WriteLine("============================");



            sw.WriteLine("YouTuBe:");
            SearchEnginBase youtube = new YoutubeEngin();
            List<SearchTerm> result3 = youtube.SearchKeyWordByTerm("iphone");
            if (result3 == null || result3.Count == 0)
            {
                sw.WriteLine("search result is empty!");
            }
            else
            {
                foreach (SearchTerm s in result3)
                {
                    sw.WriteLine(s.Term + "::  " + s.Keyword);
                }
            }
            sw.WriteLine("============================");


            sw.WriteLine("Google Play:");
            SearchEnginBase googlePlay = new GooglePlayEngin();
            List<SearchTerm> result4 = googlePlay.SearchKeyWordByTerm("iphone");
            if (result4 == null || result4.Count == 0)
            {
                sw.WriteLine("search result is empty!");
            }
            else
            {
                foreach (SearchTerm s in result4)
                {
                    sw.WriteLine(s.Term + "::  " + s.Keyword);
                }
            }
            sw.WriteLine("============================");



            sw.WriteLine("Amazon:");
            SearchEnginBase amazon = new AmazonEngin();
            List<SearchTerm> result5 = amazon.SearchKeyWordByTerm("iphone");
            if (result5 == null || result5.Count == 0)
            {
                sw.WriteLine("search result is empty!");
            }
            else
            {
                foreach (SearchTerm s in result5)
                {
                    sw.WriteLine(s.Term + "::  " + s.Keyword);
                }
            }
            sw.WriteLine("============================");

            sw.Flush();
            fs.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
