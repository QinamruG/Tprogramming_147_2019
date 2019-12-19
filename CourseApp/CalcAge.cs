using System;

namespace CourseApp
{
    public class CalcAge
    {
        private DateTime now = DateTime.Today;

        public string CalculateAge(int day, int month, int year, bool fullAge, bool currentTime)
        {
            var birthday = new DateTime(year, month, day);
            var today = DateTime.Today;

            if (currentTime == false)
            {
                today = new DateTime(2019, 12, 19);
            }

            if (birthday.Ticks > now.Ticks)
            {
                throw new Exception("you cannot enter a date that did not occur");
            }
            else if (birthday.Ticks == now.Ticks)
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