using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SearchEngin
{
    class AmazonEngin : SearchEnginBase
    {

        private const string AMAZON_SEARCH_URL_PREFIX = "https://completion.amazon.com/search/complete?method=completion&mkt=1&client=amazon-search-ui&x=String&search-alias=aps&qs=&cf=1&noCacheIE=1443365029891&fb=1&sc=1&q=";

        //解析返回的keyword
        public override List<string> parseKeywordsFromResponse(string searchResponse)
        {
            if (searchResponse == null || searchResponse.Trim().Length == 0)
            {
                return null;
            }
            searchResponse = searchResponse.Trim();

            int s = searchResponse.IndexOf("=");
            if(s >= 0)
            {
                searchResponse = searchResponse.Substring(s + 1, searchResponse.Length - s - 1);
            }
            int e = searchResponse.LastIndexOf(";String();");
            if (e >= 0)
            {
                searchResponse = searchResponse.Substring(0, e);
            }

            searchResponse = searchResponse.Trim();

            JArray ja = (JArray)JsonConvert.DeserializeObject(searchResponse);
            if (ja.Count < 2)
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
                string keyword = keywordArray[i].ToString(); ;
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
            return AMAZON_SEARCH_URL_PREFIX + queryStr;
        }
    }
}
