using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/filled_madlibs")]
    public ActionResult FilledMadLibs()
    {
      WordVariable myWordVariable = new WordVariable();
      myWordVariable.SetPerson1(Request.Query["person1"]);
      myWordVariable.SetPerson2(Request.Query["person2"]);
      myWordVariable.SetAnimal(Request.Query["animal"]);
      myWordVariable.SetExclamation(Request.Query["exclamation"]);
      myWordVariable.SetVerb(Request.Query["verb"]);
      myWordVariable.SetNoun(Request.Query["noun"]);
      return View("MadLibs", myWordVariable);
    }
  }
}
