using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PieceOfArtTest
    {
        [Fact]
        public void TestEmptyConstructorForPicture()
        {
            var item = new Picture();
            Assert.Equal(0, item.ProdYear);
            Assert.Equal("Untitled", item.Name);
            Assert.Equal("No country", item.Country);
        }

        [Fact]
        public void TestForVirtualMethod()
        {
            var item = new Film();
            Assert.Equal("Virtual Method", item.VirtualView());
        }
    }
}