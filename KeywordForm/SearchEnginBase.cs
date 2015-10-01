using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Http;

namespace SearchEngin
{
    class SearchEnginBase
    {

        private char[] LETTERS = {
                                                  'a', 'b', 'c', 'd', 'e', 'f',
                                                  'g', 'h', 'i', 'j', 'k', 'l',
                                                  'm', 'n', 'o', 'p', 'q', 'r',
                                                  's', 't', 'u', 'v', 'w', 'x',
                                                  'y', 'z'
                                              };
        private int[] NUMS = {
                                              0, 1, 2, 3, 4, 5, 
                                              6, 7, 8, 9, 10
                                          };

        public List<SearchTerm> SearchKeyWordByTerm(string term)
        {
            if (term == null || term.Trim().Length == 0)
            {
                return null;
            }
            List<string> terms = getSearchTerms(term.Trim());
            if (terms == null || terms.Count == 0)
            {
                return null;
            }
            List<SearchTerm> result = new List<SearchTerm>();
            foreach(string newTerm in terms)
            {
                string searchUrl = getSearchUrl(newTerm);
                string searchResponse = HttpHelper.HttpGet(searchUrl);
                if (searchResponse == null || searchResponse.Trim().Length == 0)
                {
                    continue;
                }
                List<string> keywords = parseKeywordsFromResponse(searchResponse);
                if (keywords == null || keywords.Count == 0)
                {
                    continue;
                }
                foreach (string keyword in keywords)
                {
                    SearchTerm s = new SearchTerm();
                    s.Term = newTerm;
                    s.Keyword = keyword;
                    result.Add(s);
                }
            }
            return result;
        }

        //解析返回的keyword
        public virtual List<string> parseKeywordsFromResponse(string searchResponse)
        {
            throw new NotImplementedException();
        }

        //获取对应的搜算关键字url
        public virtual string getSearchUrl(string newTerm)
        {
            throw new NotImplementedException();
        }

        //在输入的term后面 拼上 空格/0-10/a-z
        private List<string> getSearchTerms(string term)
        {
            if (term == null || term.Trim().Length == 0)
            {
                return null;
            }
            term = term.Trim();
            List<string> result = new List<string>();
            result.Add(term);
            result.Add(term + " ");

            foreach (char a in LETTERS)
            {
                result.Add(term + " " + a);
            }

            foreach (int b in NUMS)
            {
                result.Add(term + " " + b);
            }

            return result;
        }
    }
}
