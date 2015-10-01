using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Winista.Text.HtmlParser;
using Winista.Text.HtmlParser.Filters;
using Winista.Text.HtmlParser.Util;

namespace SearchEngin
{
    class BingEngin : SearchEnginBase
    {

        private const string BING_SEARCH_URL_PREFIX = "http://www.bing.com/AS/Suggestions?pt=page.home&mkt=en-us&cp=6&o=hs&cvid=4b518ed0f7ed4269ac85d13e757ae91b&qry=";

        //解析返回的keyword
        public override List<string> parseKeywordsFromResponse(string searchResponse)
        {
            if (searchResponse == null || searchResponse.Trim().Length == 0)
            {
                return null;
            }
            searchResponse = searchResponse.Trim();
            Parser parser = Parser.CreateParser(searchResponse, null);
            NodeList nodes = parser.ExtractAllNodesThatMatch(new TagNameFilter("li"));
            if (nodes.Count <= 0)
            {
                return null;
            }
            List<string> result = new List<string>();
            for (int i = 0; i < nodes.Count; i++)
            {
                INode node = nodes[i];
                string keyword = node.ToPlainTextString();
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
            return BING_SEARCH_URL_PREFIX + queryStr;
        }
    }
}
