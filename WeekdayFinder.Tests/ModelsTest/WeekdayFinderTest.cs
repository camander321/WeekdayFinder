using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;

namespace WeekdayFinder.Models.Tests
{
  [TestClass]
  public class ProjectTest
  {
    [TestMethod]
    public void GetDay_ReturnDay_True()
    {
      Weekday weekday = new Weekday("2018-01-01");

      Assert.AreEqual(1 , weekday.GetDay());
    }
    [TestMethod]
    public void GetMonth_ReturnMonth_True()
    {
      Weekday weekday = new Weekday("2018-01-01");

      Assert.AreEqual(1 , weekday.GetMonth());
    }
    [TestMethod]
    public void GetYear_ReturnYear_True()
    {
      Weekday weekday = new Weekday("2018-01-01");

      Assert.AreEqual(2018 , weekday.GetYear());
    }

    [TestMethod]
    public void GetWeekDay_CalculateWeekDay_True()
    {
      Weekday weekday = new Weekday("2018-01-01");

      Assert.AreEqual("Monday" , weekday.GetWeekDay());
    }
  }
}
