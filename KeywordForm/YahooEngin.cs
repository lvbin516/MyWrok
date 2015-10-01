using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SearchEngin
{
    class YahooEngin : SearchEnginBase
    {

        private const string YAHOO_SEARCH_URL_PREFIX = "https://search.yahoo.com/sugg/gossip/gossip-us-fp/?nresults=10&queryfirst=2&appid=fp&output=json&version=&command=";

        //解析返回的keyword
        public override List<string> parseKeywordsFromResponse(string searchResponse)
        {
            if (searchResponse == null || searchResponse.Trim().Length == 0)
            {
                return null;
            }
            searchResponse = searchResponse.Trim();

            JObject jo = (JObject)JsonConvert.DeserializeObject(searchResponse);
            JArray  keywordArray = (JArray)jo["gossip"]["results"];

            if (keywordArray.Count <= 0)
            {
                return null;
            }

            List<string> result = new List<string>();
            for (int i = 0; i < keywordArray.Count; i++)
            {
                JObject keywordObj = (JObject)keywordArray[i];
                string keyword = keywordObj["key"].ToString();
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
            return YAHOO_SEARCH_URL_PREFIX + queryStr;
        }
    }
}
