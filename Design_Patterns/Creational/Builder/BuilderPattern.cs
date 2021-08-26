using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    public class Search
    {
        public int Offset { get; set; }
        public int PageSize { get; set; }
        public string SearchString { get; set; }
        public string SortOrder { get; set; }
        public string SortBy { get; set; }
        
        public Search(int offset, int pageSize, string searchString, string sortOrder, string sortBy)
        {
            Offset = offset;
            PageSize = pageSize;
            SearchString = searchString;
            SortOrder = sortOrder;
            SortBy = sortBy;
        }

        public Search()
        {

        }

    }

    public class SearcrhBuilder
    {
        private Search searchObj = new Search();

        public SearcrhBuilder SetSortBy(string sortBy)
        {
            searchObj.SortBy = sortBy;
            return this;
        }

        public SearcrhBuilder SetOffset(int offset)
        {
            searchObj.Offset = offset;
            return this;
        }

        public SearcrhBuilder SetPageSize(int pageSize)
        {
            searchObj.PageSize = pageSize;
            return this;
        }

        public SearcrhBuilder SetSortOrder(string sortOrder)
        {
            searchObj.SortOrder = sortOrder;
            return this;
        }

        public SearcrhBuilder SetSearchString(string searchString)
        {
            searchObj.SearchString = searchString;
            return this;
        }

        public Search GetObject()
        {
            return searchObj;
        }
    }


}
