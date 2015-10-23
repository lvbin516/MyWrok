using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using SearchEngin;

namespace KeywordForm
{
    class SearchThread
    {
        private SearchEnginBase engin;
        private List<string> terms;
        private int start;
        private int end;
        private ConcurrentDictionary<string, List<SearchTerm>> conMap;

        public SearchThread(SearchEnginBase engin, List<string> terms, int start, int end, ConcurrentDictionary<string, List<SearchTerm>> conMap)
        {
            this.engin = engin;
            this.terms = terms;
            this.start = start;
            this.end = end;
            this.conMap = conMap;
        }

        public void searchByThread()
        {
            if (this.engin == null || this.terms == null || this.terms.Count == 0
                || this.start < 0 || this.end < 0 || conMap == null)
            {
                return;
            }
            for (int i = this.start; i < this.end && i < this.terms.Count; i++)
            {
                List <SearchTerm> result = engin.SearchKeyWordByTerm0(this.terms[i]);
                if (result == null || result.Count == 0)
                {
                    continue;
                }
                this.conMap.GetOrAdd(this.terms[i], result);
            }
        }

    }
}
