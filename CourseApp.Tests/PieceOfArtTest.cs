using System;
using System.Collections.Generic;
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

        [Fact]
        public void ICompareTest()
        {
            var pArr = new List<PieceOfArt>() { new Film(1888, "B", "any"), new Film(1889, "C", "any"), new Picture(1890, "A", "any") };
            string s = string.Empty;
            string s2 = string.Empty;
            foreach (var p in pArr)
            {
                s += p.Name;
            }

            pArr.Sort();
            foreach (var p in pArr)
            {
                s2 += p.Name;
            }

            Assert.True(s != s2);
        }

        [Fact]
        public void ICompareCorrectWorkTest()
        {
            var pArr = new List<PieceOfArt>() { new Film(1888, "B", "any"), new Film(1889, "C", "any"), new Picture(1890, "A", "any") };
            string s = string.Empty;
            pArr.Sort();
            foreach (var p in pArr)
            {
                s += p.Name;
            }

            Assert.Equal("ABC", s);
        }
    }
}