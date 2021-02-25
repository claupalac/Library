using System.Collections.Generic;

namespace Library.Search
{
    public interface ISearcher
    {
        string GetItemSearched(List<string> list, string wanted, IComparator comparator);
        int GetIndexItemSearched(List<string> list, string wanted, IComparator comparator);
    }
}