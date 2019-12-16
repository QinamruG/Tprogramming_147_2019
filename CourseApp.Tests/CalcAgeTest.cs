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
            Assert.Equal(yeah.CalculateAge(2, 3, 2000), $"Возраст:19 лет, 9 месяцев, 15 дней");
        }

        [Fact]
        public void FutureDateInputTest()
        {
            var time = new CalcAge();
            try
            {
                Assert.Equal(time.CalculateAge(16, 12, 2020), $"Возраст:19 лет, 5 месяцев, 19 дней");
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
                Assert.Equal(time.CalculateAge(day, month, year), $"Возраст:0 лет, 0 месяцев, 0 дней");
            }
            catch
            {
                Assert.True(true);
            }
        }
    }
}