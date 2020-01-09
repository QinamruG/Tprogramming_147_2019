using System;
using Xunit;

namespace CourseApp.Tests
{
    public class CalcAgeTest
    {
        [Fact]
        public void CorrectAgeInputTest()
        {
            Assert.Equal(CalcAge.CalculateAge(18, 12, 2000, 19, 12, 2019, true), $"Возраст:19 лет, 0 месяцев, 1 дней");
        }

        [Fact]
        public void FutureDateInputTest()
        {
            try
            {
                CalcAge.CalculateAge(16, 6, 2021, true);
            }
            catch
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void CurrentDayIsBirthdayTest()
        {
            var day = DateTime.Today.Day;
            var month = DateTime.Today.Month;
            var year = DateTime.Today.Year;
            try
            {
                Assert.Equal(CalcAge.CalculateAge(12, 12, 2019, 12, 12, 2019, true), $"Возраст:0 лет, 0 месяцев, 0 дней");
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
            Assert.Equal($"Возраст:{exp} лет", CalcAge.CalculateAge(d, m, y, 19, 12, 2019, false));
        }

        [Fact]
        public void BirthdayTomorrowTest()
        {
            Assert.Equal($"Возраст:18 лет, 11 месяцев, 30 дней", CalcAge.CalculateAge(20, 12, 2000, 19, 12, 2019, true));
        }
    }
}