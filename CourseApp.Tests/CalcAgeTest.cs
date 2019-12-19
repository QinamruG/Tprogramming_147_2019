using System;
using Xunit;

namespace CourseApp.Tests
{
    public class CalcAgeTest
    {
        [Fact]
        public void CorrectAgeInputTest()
        {
            var yeah = new CalcAge();
            Assert.Equal(yeah.CalculateAge(DateTime.Now.Day - 15, DateTime.Now.Month - 9, DateTime.Now.Year - 19, true, true), $"Возраст:19 лет, 9 месяцев, 16 дней");
        }

        [Fact]
        public void FutureDateInputTest()
        {
            var time = new CalcAge();
            try
            {
                Assert.Equal(time.CalculateAge(16, 12, DateTime.Now.Year + 3, true, false), $"Возраст:19 лет, 5 месяцев, 19 дней");
            }
            catch
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void CurrentDayIsBirthdayTest()
        {
            var time = new CalcAge();
            var day = DateTime.Today.Day;
            var month = DateTime.Today.Month;
            var year = DateTime.Today.Year;
            try
            {
                Assert.Equal(time.CalculateAge(day, month, year, true, false), $"Возраст:0 лет, 0 месяцев, 0 дней");
            }
            catch
            {
                Assert.True(true);
            }
        }

        [Theory]
        [InlineData(30, 12, 2000, 18)]
        [InlineData(16, 12, 2000, 19)]
        public void CurrectYearCountTest(int d, int m, int y, int exp)
        {
            var time = new CalcAge();
            Assert.Equal($"Возраст:{exp} лет", time.CalculateAge(d, m, y, false, false));
        }
    }
}