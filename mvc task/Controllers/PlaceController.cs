using Microsoft.AspNetCore.Mvc;
using placeApp.Models;

namespace placeApp.Controllers
{
    public class PlaceController : Controller
    {
        public IActionResult GetPlace()
        {
            Places place = new Places() { num = 1, name = "Ibiza" };
            return View("Places", place);
        }

    }
}
