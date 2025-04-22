using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetWebDemo.Logic.Tests
{
    [TestClass()]
    public class DateCalculationsTests
    {
        [TestMethod()]
        public void GetEasterSundayTest()
        {
            // arrange
            int year = 2025;
            DateTime expectedSunday = new(2025, 4, 20);

            // act
            DateTime actual = DateCalculations.GetEasterSunday(year);

            // assert
            Assert.AreEqual(expectedSunday, actual);
        }

        [TestMethod]
        [DataRow(2024, 3, 31)]
        [DataRow(2023, 4, 9)]
        [DataRow(2022, 4, 17)]
        [DataRow(2000, 4, 23)]
        [DataRow(1990, 4, 15)]
        [DataRow(1900, 4, 15)]
        [DataRow(2100, 3, 28)]
        public void GetEasterSunday_ValidYears_ReturnsCorrectDate(int year, int expectedMonth, int expectedDay)
        {
            // Act
            DateTime result = DateCalculations.GetEasterSunday(year);

            // Assert
            Assert.AreEqual(year, result.Year, "Year should match input");
            Assert.AreEqual(expectedMonth, result.Month, "Month is incorrect");
            Assert.AreEqual(expectedDay, result.Day, "Day is incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetEasterSunday_YearBelowRange_ThrowsException()
        {
            _ = DateCalculations.GetEasterSunday(1899);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetEasterSunday_YearAboveRange_ThrowsException()
        {
            _ = DateCalculations.GetEasterSunday(2101);
        }
    }
}
