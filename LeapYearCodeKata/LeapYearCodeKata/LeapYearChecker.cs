namespace LeapYearCodeKata
{
    public class LeapYearChecker
    {
        public bool IsLeap(int year)
        {
            return year % 4 == 0 && !IsNotTypicalLeap(year);
        }

        private static bool IsNotTypicalLeap(int year)
        {
            return year % 100 == 0 && year % 400 != 0;
        }
    }
}
