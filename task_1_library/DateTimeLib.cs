namespace task_1_library
{
    public class DateTimeLib
    {
        public DateTime date_dif(DateTime date1, DateTime date2)
        {
            TimeSpan new_date;

            if (date1 >= date2)
            {
                new_date = date1.Subtract(date2);
            }
            else
            {
                new_date = date2.Subtract(date1);
            }
            DateTime dt = new DateTime();

            return dt.Add(new_date);
        }

        public bool isYearLeap(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        public string timesOfDay(DateTime date)
        {
            string[] timeOfDay = { "ночь","ночь","ночь","ночь", // 0 - 3
                                "утро","утро","утро","утро","утро","утро","утро","утро", // 4 - 11
                                "день","день","день","день","день", // 12 - 16
                                "вечер","вечер","вечер","вечер","вечер","вечер","вечер" // 17 - 23
                                 };

            return timeOfDay[date.Hour];
        }

        public string formatDate(DateTime date, string format)
        {
            try
            {
                return date.ToString(format);
            }
            catch
            {
                return "Error: Выбранный вами формат отсутствует";
            }
        }
    }
}