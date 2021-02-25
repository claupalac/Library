using System;
using System.Collections.Generic;
using Library;
using Xunit;

namespace LibraryTests
{
    public class LibraryTest : IDisposable
    {
        private Librarian _library;

        public LibraryTest()
        {
            _library = new Librarian();
        }
        
        public void Dispose()
        {
            _library = null;
        }
        
        [Fact]
        void SortBooks_WithListContainingOddBooks_ShouldReturnListSortedAscendant()
        {
            List<string> books = new List<string>()
            {
                "Asus", "Crear o Morir", "Steve Jobs", "TOEFL", "Hola"
            };
            List<string> favoriteBooks = new List<string>()
            {
                "Asus", "Steve Jobs"
            };

            List<string> expected = new List<string>()
            {
                "Asus", "Steve Jobs",  "Crear o Morir", "Hola", "TOEFL"
            };

            List<string> actual = _library.SortBooks(books, favoriteBooks);
            
            Assert.Equal(expected,actual);
        }
        
        [Fact]
        void SortBooks_WithListContainingEvenBooks_ShouldReturnListSortedAscendant()
        {
            List<string> books = new List<string>()
            {
                "TedTalks", "Crear o Morir", "Steve Jobs", "Toefl"
            };
            List<string> favoriteBooks = new List<string>()
            {
                "TedTalks", "Steve Jobs", "Toefl"
            };

            List<string> expected = new List<string>()
            {
                "Steve Jobs", "TedTalks", "Toefl", "Crear o Morir"
            };

            List<string> actual = _library.SortBooks(books, favoriteBooks);
            
            Assert.Equal(expected,actual);
        }
        
        [Fact]
        void SortBooks_WithEmptyFavoriteList_ShouldReturnListOfBooksSortedAscendant()
        {
            List<string> books = new List<string>()
            {
                "Create", "Asus", "Steve", "Bible", "Narnia"
            };
            List<string> favoriteBooks = new List<string>()
            {
                
            };

            List<string> expected = new List<string>()
            {
                "Asus", "Bible",  "Create", "Narnia", "Steve"
            };

            List<string> actual = _library.SortBooks(books, favoriteBooks);
            
            Assert.Equal(expected,actual);
        }
        
        [Fact]
        void SearchBooks_WithListContainingEvenBooks_ShouldReturnListWithTwoBooks()
        {
            List<string> books = new List<string>()
            {
                "Maradona", "Messi" , "Ronaldinho", "Ronaldo"
            };
            
            string searchedValue = "Ron";
            
            List<string> expected = new List<string>()
            {
                "Ronaldinho", "Ronaldo"
            };
            
            List<string> actual = _library.SearchBooks(books, searchedValue);
            
            Assert.Equal(expected,actual);
        }
        
        [Fact]
        void SearchBooks_WithListNotContainingTheSearchedValue_ShouldReturnEmptyList()
        {
            List<string> books = new List<string>()
            {
                "Maradona", "Messi" , "Ronaldinho", "Ronaldo"
            };
            List<string> expected = new List<string>();
                
            string searchedValue = "Ney";

            List<string> actual = _library.SearchBooks(books, searchedValue);
            
            Assert.Empty(actual);
        }
    }
}