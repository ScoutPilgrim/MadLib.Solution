using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult MadLib(string exclamation, string adverb, string noun, string adjective)
    {
       MadLib myMadLib = new MadLib(exclamation, adverb, noun, adjective);
      return View(myMadLib);
    }
  }
}
