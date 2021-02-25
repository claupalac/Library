using System;
using System.Collections.Generic;

namespace Library.Search
{
    public class BinarySearcher : ISearcher
    {
       
        public string GetItemSearched(List<string> list, string wanted, IComparator comparator)
        {
            return BinarySearch(list, 0, list.Count, wanted, comparator);
        }

        public int GetIndexItemSearched(List<string> list, string wanted, IComparator comparator)
        {
            return BinarySearchIndex(list, 0, list.Count, wanted, comparator);
        }

        private string BinarySearch(List<string> list, int startingIndex, int endingIndex, string wanted, IComparator comparator)
        {
            
            if (endingIndex >= startingIndex) 
            { 
                int middleIndex = startingIndex + (endingIndex - startingIndex) / 2;
                
                if (middleIndex > list.Count-1) return null;
                
                if (comparator.Compare(list[middleIndex],wanted) == 0) 
                    return list[middleIndex]; 
                
                if (comparator.Compare(list[middleIndex],wanted) > 1) 
                    return BinarySearch(list, startingIndex, middleIndex - 1, wanted,comparator); 
                
                return BinarySearch(list, middleIndex + 1, endingIndex, wanted,comparator); 
            }
            return null; 
        }
        
        private int BinarySearchIndex(List<string> list, int startingIndex, int endingIndex, string wanted, IComparator comparator)
        {
            
            if (endingIndex >= startingIndex) { 
                int middleIndex = startingIndex + (endingIndex - startingIndex) / 2; 
                
                if (comparator.Compare(list[middleIndex],wanted) == 0) 
                    return middleIndex; 
                
                if (comparator.Compare(list[middleIndex],wanted) >= 1) 
                    return BinarySearchIndex(list, startingIndex, middleIndex - 1, wanted,comparator); 
                
                return BinarySearchIndex(list, middleIndex + 1, endingIndex, wanted,comparator); 
            }
            return -1; 
        }
    }
}