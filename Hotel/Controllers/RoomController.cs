using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
