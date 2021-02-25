using System.Collections.Generic;
using Library;
using Library.Search;
using Xunit;

namespace LibraryTests
{
    public class BinarySearchTest
    {
        [Fact]
        void Search_WithListContainingTheSearchedValue_ShouldReturnSearchedValue()
        {
            ISearcher searcher = new BinarySearcher();
            var searchedValue = "Claudio";
            List<string> aList = new List<string>()
            {
                "Bustillos", "Claudio", "Iniesta", "Palacios", "Vanessa", "Jupiter"
            };

            var actual = searcher.GetItemSearched(aList, searchedValue, new ComparatorAscendant());
            
            
            Assert.Equal(searchedValue, actual);
        }
        
        [Fact]
        void SearchIndex_WithListContainingTheSearchedValue_ShouldReturnIndexSearchedValue()
        {
            ISearcher searcher = new BinarySearcher();
            var searchedValue = "Claudio";
            List<string> aList = new List<string>()
            {
                "Bustillos", "Claudio", "Iniesta", "Palacios", "Vanessa"
            };

            var actual = searcher.GetIndexItemSearched(aList, searchedValue, new ComparatorAscendant());
            
            
            Assert.Equal(1,actual);
        }
        
        [Fact]
        void Search_WithSearchedValueStartingWith_ShouldReturnSearchedValue()
        {
            ISearcher searcher = new BinarySearcher();
            var searchedValue = "Clau";
            var expected = "Claudio";
            List<string> aList = new List<string>()
            {
                "Bustillos", "Claudio", "Iniesta", "Palacios", "Vanessa", "Jupiter"
            };

            var actual = searcher.GetItemSearched(aList, searchedValue, new ComparatorStartsWith());
            
            
            Assert.Equal(expected, actual);
        }
    }
}