using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Winista.Text.HtmlParser;
using Winista.Text.HtmlParser.Data;

namespace SearchEngin
{
    class GoogleEngin : SearchEnginBase
    {

        private const string GOOGLE_SEARCH_URL_PREFIX = "https://www.google.com/s?sclient=psy-ab&hl=en&site=webhp&source=hp&oq=&gs_l=&pbx=1&bav=on.2,or.&bvm=bv.103388427,d.cGU&fp=a1a7b5d7088bd8a9&biw=1920&bih=393&dpr=1&pf=p&gs_rn=64&gs_ri=psy-ab&cp=6&gs_id=6&xhr=t&tch=1&ech=1&psi=HJcHVqmNFJe4ogSEn6yYDw.1443337979044.1&q=";

        private const string GOOGLE_RES_SUFFIX = "/*";

        //解析返回的keyword
        public override List<string> parseKeywordsFromResponse(string searchResponse)
        {
            if (searchResponse == null || searchResponse.Trim().Length == 0)
            {
                return null;
            }
            searchResponse = searchResponse.Trim();
            int q = searchResponse.IndexOf(GOOGLE_RES_SUFFIX);
            if (q >= 0)
            {
                searchResponse = searchResponse.Substring(0, q);
            }
            JObject jo = (JObject)JsonConvert.DeserializeObject(searchResponse);
            string keywordsJson = jo["d"].ToString();

            if (keywordsJson == null || keywordsJson.Trim().Length == 0)
            {
                return null;
            }
            keywordsJson = keywordsJson.Trim();

            JArray ja = (JArray)JsonConvert.DeserializeObject(keywordsJson);
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
                keyword = keyword.Replace("<b>", "");
                keyword = keyword.Replace("</b>", "");
                //替换特殊字符
                keyword = keyword.Replace("&#160;", " ");
                keyword = keyword.Replace("&#60;", "<");
                keyword = keyword.Replace("&#62;", ">");
                keyword = keyword.Replace("&#38;", "&");
                keyword = keyword.Replace("&#34;", "\"");
                keyword = keyword.Replace("&#39;", "'");
                keyword = keyword.Replace("&#215;", "×");
                keyword = keyword.Replace("&#247;", "÷");

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
            return GOOGLE_SEARCH_URL_PREFIX + queryStr;
        }
    }
}
