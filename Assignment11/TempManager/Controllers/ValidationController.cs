using Microsoft.AspNetCore.Mvc;
using TempManager.Models;

namespace Ch11Ex1TempManager.Controllers
{
    public class ValidationController : Controller
    {
        private readonly TempManagerContext tmpcontxt; //Tempmanagercontext
        public ValidationController(TempManagerContext tempManagerContext)
        {
            tmpcontxt = tempManagerContext;
        }

        public JsonResult CheckDate(string date)
        {
            var parsedDate = System.DateTime.Parse(date);
            var tempRecords = tmpcontxt.Temps;

            var dateExists = false;

            foreach (var temp in tempRecords)
            {
                if (temp.Date == parsedDate)
                {
                    dateExists = true;
                }
            }

            if (!dateExists)
            {
                return Json(true);
            }

            return Json("Duplicate dates used!");

        }
    }

}