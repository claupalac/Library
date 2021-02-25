using System;

namespace Library
{
    public class ComparatorAscendant:IComparator
    {
        public int Compare(string string1, string string2)
        {
            return string.Compare(string1, string2, StringComparison.Ordinal);
        }
    }
}