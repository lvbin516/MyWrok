using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Http;
using System.Collections.Concurrent;
using System.Threading;
using KeywordForm;

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

        private int THREAD_NUM = Environment.ProcessorCount; 

        //搜索关键字
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
            ConcurrentDictionary<string, List<SearchTerm>> conMap = new ConcurrentDictionary<string, List<SearchTerm>>();

            //创建搜索线程
            createSearchThread(conMap, terms, THREAD_NUM);

            List<SearchTerm> empty = null;
            List<SearchTerm> result = new List<SearchTerm>();
            foreach (string t in terms)
            {
                List<SearchTerm> subResult = conMap.GetOrAdd(t, empty);
                if (subResult == null || subResult.Count == 0)
                {
                    continue;
                }
                result.AddRange(subResult);
            }
            return result;
        }

        private void createSearchThread(ConcurrentDictionary<string, List<SearchTerm>> conMap, List<string> terms, int threadNum)
        {
            if(threadNum <= 0)
            {
                threadNum = THREAD_NUM;
            }
            if(conMap == null || terms == null || terms.Count == 0)
            {
                return ;
            }

            int numPerThread = terms.Count / threadNum;
            if (terms.Count % threadNum != 0)
            {
                numPerThread += 1;
            }

            List<Thread> searchThread = new List<Thread>();
            for (int i = 0; i < threadNum; i++)
            {
                int start = i * numPerThread;
                int end = start + numPerThread;
                SearchThread st = new SearchThread(this, terms, start, end, conMap);
                Thread t = new Thread(st.searchByThread);
                t.Start();
                searchThread.Add(t);
            }
            foreach (Thread st in searchThread)
            {
                st.Join();
            }
        }

        public List<SearchTerm> SearchKeyWordByTerm0(string term)
        {
            List<SearchTerm> result = new List<SearchTerm>();

            string searchUrl = getSearchUrl(term);
            string searchResponse = HttpHelper.HttpGet(searchUrl);
            if (searchResponse == null || searchResponse.Trim().Length == 0)
            {
                return null;
            }
            List<string> keywords = parseKeywordsFromResponse(searchResponse);
            if (keywords == null || keywords.Count == 0)
            {
                return null;
            }
            foreach (string keyword in keywords)
           {
                SearchTerm s = new SearchTerm();
                s.Term = term;
                s.Keyword = keyword;
                result.Add(s);
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
