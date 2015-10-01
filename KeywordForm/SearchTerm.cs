using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchEngin
{
    class SearchTerm
    {
        private string term;

        public string Term
        {
            get
            {
                return term;
            }
            set
            {
                this.term = value;
            }
        }

        private string keyword;

        public string Keyword
        {
            get
            {
                return keyword;
            }
            set
            {
                this.keyword = value;
            }
        }
    }
}
