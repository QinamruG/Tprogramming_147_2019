using System;

namespace CourseApp
{
    public static class CalcAge
    {
        public static string CalculateAge(int day, int month, int year, bool fullAge)
        {
            var today = DateTime.Today;
            return CalcAge.CalculateAge(day, month, year, today.Day, today.Month, today.Year, fullAge);
        }

        public static string CalculateAge(int day, int month, int year, int currDay, int currMonth, int currYear, bool fullAge)
        {
            var birthday = new DateTime(year, month, day);
            var today = new DateTime(currYear, currMonth, currDay);

            if (birthday.Ticks > today.Ticks)
            {
                throw new Exception("you cannot enter a date that did not occur");
            }
            else if (birthday.Ticks == today.Ticks)
            {
                throw new Exception("he/she/you was born today");
            }
            else
            {
                var age = new DateTime(today.Ticks - birthday.Ticks);
                if (fullAge == true)
                {
                    return $"Возраст:{age.Year - 1} лет, {age.Month - 1} месяцев, {age.Day - 1} дней";
                }
                else
                {
                    return $"Возраст:{age.Year - 1} лет";
                }
            }
        }
    }
}
