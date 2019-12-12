using System;
using Xunit;

namespace CourseApp.Tests
{
    public class FilmTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Film();
            Assert.Equal(1888, item.ProdYear);
            Assert.Equal("Untitled", item.Name);
            Assert.Equal("No country", item.Country);
        }

        [Fact]
        public void TestSetProductionYear()
        {
            var item = new Film();
            item.ProdYear = 2005;
            Assert.Equal(2005, item.ProdYear);
        }

        [Fact]
        public void TestIncorrectSetProductionYear()
        {
            var item = new Film();
            try
            {
                item.ProdYear = 120;
                Assert.Equal(1888, item.ProdYear);
            }
            catch (System.Exception)
            {
                Console.WriteLine($"Production year should be > 1888 and < than {DateTime.Now.Year}");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetProductionYear()
        {
            var item = new Film();
            try
            {
                item.ProdYear = 2008;
                item.ProdYear = 235;
                Assert.Equal(2008, item.ProdYear);
            }
            catch (System.Exception)
            {
                Console.WriteLine($"Production year should be > 1888 and < than {DateTime.Now.Year}");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectName()
        {
            var item = new Film();
            item.Country = "Russia";
            Assert.Equal("Russia", item.Country);
        }

        [Fact]
        public void TestSendFilm()
        {
            var item = new Film(1984, "GhostBusters", "America");
            var act = item.Send("Kostya");
            Assert.Equal($"Hi Kostya, can you check GhostBusters(1984) to watch? I want to know your opinion about this film))", act);
        }

        [Fact]
        public void TestWatchFilm()
        {
            var item = new Film(1984, "GhostBusters", "America");
            var act = item.Watch();
            Assert.Equal($"Now i am watching a film, named GhostBusters, which came out in 1984 from America", act);
        }
    }
}
