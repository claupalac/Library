using Library;
using Xunit;

namespace LibraryTests
{
    public class ComparatorStartsWithTest
    {
        [Fact]
        void Compare_WithStringThatContainsOtherString_ShouldReturnPositiveNumber()
        {
            string aString = "Ronaldinho";
            string partial = "Ronal";
            IComparator comparator = new ComparatorStartsWith();
            var expected = 0;
            
            var actual = comparator.Compare(aString, partial);
            
            Assert.Equal(expected,actual);
        }
        [Fact]
        void Compare_WithStringThatNotContainsOtherString_ShouldReturnNegativeNumber()
        {
            string aString = "Ronaldinho";
            string partial = "dinho";
            IComparator comparator = new ComparatorStartsWith();
            var notExpected = 0;
            
            var actual = comparator.Compare(aString, partial);
            
            Assert.NotEqual(notExpected,actual);
        }
        [Fact]
        void Compare_WithSameString_ShouldReturnZero()
        {
            string aString = "Ronaldinho";
            string partial = "Ronaldinho";
            IComparator comparator = new ComparatorStartsWith();
            var expected = 0;
            
            var actual = comparator.Compare(aString, partial);
            
            Assert.Equal(expected,actual);
        }
    }
}