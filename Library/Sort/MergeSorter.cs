using System.Collections.Generic;

namespace Library
{
    public class MergeSorter : ISorter
    {
        public void Sort(ref List<string> list, IComparator comparator)
        {
           List<string> newList = MergeSort(list, comparator);
           list = null;
           list = newList;
        }
        private List<string> MergeSort(List<string> list, IComparator comparator)
        {
            List<string> left = new List<string>();
            List<string> right = new List<string>();

            if (list.Count <= 1) 
                return list;
            int midPoint = list.Count / 2;
            for (int i = 0; i < midPoint; i++)
                left.Add(list[i]);
            
            for (int i = midPoint; i < list.Count; i++)
                right.Add(list[i]);
            
            left = MergeSort(left,comparator);
            right = MergeSort(right,comparator);
            
            return Merge(left, right, comparator);
        }
        
        private List<string> Merge(List<string> left, List<string> right, IComparator comparator)
        {
            List<string> result = new List<string>();
            int indexLeft = 0, indexRight = 0;
            while (indexLeft < left.Count || indexRight < right.Count)
            {
                if (indexLeft < left.Count && indexRight < right.Count)
                {
                    if (comparator.Compare(left[indexLeft], right[indexRight]) < 0)
                    {
                        result.Add(left[indexLeft]);
                        indexLeft++;
                    }
                    else
                    {
                        result.Add(right[indexRight]);
                        indexRight++;
                    }
                }
                else if (indexLeft < left.Count)
                {
                    result.Add(left[indexLeft]);
                    indexLeft++;
                }
                else if (indexRight < right.Count)
                {
                    result.Add(right[indexRight]);
                    indexRight++;
                }
            }

            return result;
        }
    }
}