using System.Collections.Generic;
using Library.Search;

namespace Library
{
    public class Librarian : ILibrarian
    {
        public List<string> SortBooks(List<string> books, List<string> favoriteBooks)
        {
            List<string> finalList = new List<string>();
            ISorter sorter = new MergeSorter();
            ISearcher searcher = new BinarySearcher();
            
            sorter.Sort(ref books, new ComparatorAscendant());
            sorter.Sort(ref favoriteBooks, new ComparatorAscendant());

            foreach (var variable in favoriteBooks)
            {
                int indexBook = books.BinarySearch(variable);
                if(indexBook >= 0)
                    books.RemoveAt(indexBook);
            }
            foreach (var variable in favoriteBooks)
            {
                finalList.Add(variable);
            }

            foreach (var variable in books)
            {
                finalList.Add(variable);
            }

            return finalList;
        }

        public List<string> SearchBooks(List<string> books, string partialName)
        {
            List<string> foundBooks = new List<string>();
            ISearcher searcher = new BinarySearcher();
            foreach (var aBook in books)
            {
                if (aBook.Contains(partialName))
                {
                    foundBooks.Add(aBook);
                }
            }

            return foundBooks;
        }
        
    }
}