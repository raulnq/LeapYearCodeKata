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
    }
}
