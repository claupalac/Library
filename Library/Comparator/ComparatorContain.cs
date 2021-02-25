using System;

namespace Library
{
    public class ComparatorContain : IComparator
    {
        public int Compare(string string1, string string2)
        {
            if (string1.Contains(string2))
            {
                return 0;
            }
            else
            {
                return string.Compare(string1, string2, StringComparison.Ordinal);;
            }    
        }
    }
}