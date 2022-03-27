using Microsoft.AspNetCore.Mvc;

using NFLTeams.Models;

namespace NFLTeams.Controllers
{
    public class NameController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var session = new NFLSession(HttpContext.Session);
            var model = new TeamListViewModel
            {
                ActiveConf = session.GetActiveConf(),
                ActiveDiv = session.GetActiveDiv(),
                Teams = session.GetMyTeams(),
                UserName = session.GetMyUsername()
            };

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Change(TeamListViewModel model)
        {
            var session = new NFLSession(HttpContext.Session);
            session.SetMyUsername(model.UserName);
            return RedirectToAction("Index", "Home", new { ActiveConf = session.GetActiveConf(), ActiveDiv = session.GetActiveDiv() });
        }
    }
}