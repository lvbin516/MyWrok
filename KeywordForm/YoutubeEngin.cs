using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SearchEngin
{
    class YoutubeEngin : SearchEnginBase
    {

        private const string YOUTUBE_SEARCH_URL_PREFIX = "https://clients1.google.com/complete/search?client=youtube&hl=en&gl=us&gs_rn=23&gs_ri=youtube&ds=yt&cp=3&gs_id=1s&gs_gbg=C8kWLqYVY&q=";

        //解析返回的keyword
        public override List<string> parseKeywordsFromResponse(string searchResponse)
        {
            if (searchResponse == null || searchResponse.Trim().Length == 0)
            {
                return null;
            }
            searchResponse = searchResponse.Trim();

            int q = searchResponse.IndexOf("(");
            if (q >= 0)
            {
                searchResponse = searchResponse.Substring(q + 1, searchResponse.Length - q - 2);
            }

            JArray ja = (JArray)JsonConvert.DeserializeObject(searchResponse);
            if (ja.Count != 3)
            {
                return null;
            }
            JArray keywordArray = (JArray)ja[1];

            if (keywordArray.Count <= 0)
            {
                return null;
            }

            List<string> result = new List<string>();
            for (int i = 0; i < keywordArray.Count; i++)
            {
                JArray keywordJa = (JArray)keywordArray[i];
                string keyword = keywordJa[0].ToString();
                result.Add(keyword);
            }
            return result;
        }

        //获取对应的搜算关键字url
        public override string getSearchUrl(string newTerm)
        {
            if (newTerm == null || newTerm.Trim().Length == 0)
            {
                return null;
            }
            newTerm = newTerm.Trim();
            string queryStr = HttpUtility.UrlEncode(newTerm, Encoding.UTF8);
            return YOUTUBE_SEARCH_URL_PREFIX + queryStr;
        }
    }
}
