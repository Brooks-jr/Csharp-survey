
using Microsoft.AspNetCore.Mvc;

namespace CallingCard.Controllers
{
    public class SurveyController : Controller
    {

       
        // [HttpGet]
        // [Route("survey")]
        // public IActionResult Survey()
        // {
        //     return View();
        // }

        [HttpGet]
        [Route("survey")]
        public IActionResult Survey()
        {
            
        return View();
        }

        [HttpPost]
        [Route("results")]
        public IActionResult Results(string Name, string Location, string FavWeapon, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.FavWeapon = FavWeapon;
            ViewBag.Comment = Comment;
            return View();
        }

    }
}