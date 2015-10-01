using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SearchEngin
{
    class GooglePlayEngin : SearchEnginBase
    {

        private const string PLAY_SEARCH_URL_PREFIX = "https://market.android.com/suggest/SuggRequest?json=1&c=0&hl=en&gl=US&query=";

        //解析返回的keyword
        public override List<string> parseKeywordsFromResponse(string searchResponse)
        {
            if (searchResponse == null || searchResponse.Trim().Length == 0)
            {
                return null;
            }
            searchResponse = searchResponse.Trim();

            JArray keywordArray = (JArray)JsonConvert.DeserializeObject(searchResponse);
            
            if (keywordArray.Count <= 0)
            {
                return null;
            }

            List<string> result = new List<string>();
            for (int i = 0; i < keywordArray.Count; i++)
            {
                JObject keywordJa = (JObject)keywordArray[i];
                string keyword = keywordJa["s"].ToString();
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
            return PLAY_SEARCH_URL_PREFIX + queryStr;
        }
    }
}
