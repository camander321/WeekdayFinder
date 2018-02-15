using Microsoft.AspNetCore.Mvc;
using System;
using WeekdayFinder.Models;

namespace WeekdayFinder.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("Index");
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      Weekday model = new Weekday(Request.Form["date"]);

      return View("Result", model);
    }
  }
}
