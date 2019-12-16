using System;

namespace CourseApp
{
    public class CalcAge
    {
        private DateTime now = DateTime.Today;

        public string CalculateAge(int day, int month, int year)
        {
            var birthday = new DateTime(year, month, day);
            var today = DateTime.Today;
            var age = new DateTime(today.Ticks - birthday.Ticks);
            return $"Возраст:{age.Year - 1} лет, {age.Month - 1} месяцев, {age.Day - 1} дней";
        }
    }
}
