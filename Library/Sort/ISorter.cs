using System.Collections.Generic;

namespace Library
{
    public interface ISorter
    {
        void Sort(ref List<string> list, IComparator comparator);
    }
}