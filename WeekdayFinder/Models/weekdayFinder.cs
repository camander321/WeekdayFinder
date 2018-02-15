using System;

namespace WeekdayFinder.Models
{
  public class Weekday
  {

    private int _month;
    private int _day;
    private int _year;

    public Weekday(string date)
    {
      _month = int.Parse(date.Substring(8, 2));
      _day = int.Parse(date.Substring(5, 2));
      _year = int.Parse(date.Substring(0, 4));
    }

    public int GetMonth()
    {
      return _month;
    }

    public int GetDay()
    {
      return _day;
    }

    public int GetYear()
    {
      return _year;
    }

    public string GetWeekDay()
    {
      DateTime dt = new DateTime(_year, _month, _day);
      return dt.DayOfWeek.ToString();
    }



  }
}
