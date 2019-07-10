using BibliographicalWorks;
using Xunit;

namespace BibliographicalWorksTest
{
    public class AuthorTest
    {
        [Fact]
        public void When_Call_GetName_Passing_Unique_Name()
        {
            //arrange
            var author = new Author().GetName("Melfon");

            //assert
            Assert.Equal(" MELFON", author);
        }

        [Fact]
        public void When_Call_GetName_Passing_FullName()
        {
            //arrange
            var author = new Author().GetName("Laura Melfon");

            //assert
            Assert.Equal(" MELFON, Laura", author);
        }

        [Fact]
        public void When_Call_GetName_Passing_FullName_With_Junctions()
        {
            //arrange
            var author = new Author().GetName("Laura dos Santos Melfon");

            //assert
            Assert.Equal(" SANTOS MELFON, Laura dos", author);
        }

        [Fact]
        public void When_Call_GetName_Passing_FullName_With_Junctions_And_ToLowerCase()
        {
            //arrange
            var author = new Author().GetName("laura dos santos melfon");

            //assert
            Assert.Equal(" SANTOS MELFON, Laura dos", author);
        }
    }
}
