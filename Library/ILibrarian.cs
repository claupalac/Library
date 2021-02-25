using System.Collections.Generic;

namespace Library
{
    public interface ILibrarian
    {
        List<string> SortBooks(List<string> books, List<string> favoriteBooks);
        List<string> SearchBooks(List<string> books,string partialName);
    }
}