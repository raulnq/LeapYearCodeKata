using LeapYearCodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeapYearCodeKataTests
{
    [TestClass]
    public class LeapYearCheckerTests
    {
        [TestMethod]
        public void it_is_leap_year_when_is_divisible_by_4()
        {
            var checker = new LeapYearChecker();

            var isLeapYear = checker.IsLeap(1996);

            Assert.IsTrue(isLeapYear);
        }

        [TestMethod]
        public void it_is_not_leap_year_when_is_not_divisible_by_4()
        {
            var checker = new LeapYearChecker();

            var isLeapYear = checker.IsLeap(2001);

            Assert.IsFalse(isLeapYear);
        }

        [TestMethod]
        public void it_is_not_leap_year_when_is_divisible_by_4_and_100()
        {
            var checker = new LeapYearChecker();

            var isLeapYear = checker.IsLeap(1900);

            Assert.IsFalse(isLeapYear);
        }

        [TestMethod]
        public void it_is_leap_year_when_is_divisible_by_4_and_400()
        {
            var checker = new LeapYearChecker();

            var isLeapYear = checker.IsLeap(1900);

            Assert.IsTrue(isLeapYear);
        }
    }
}
