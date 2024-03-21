using Hotel.Models.Room;
using Hotel.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomService roomService;

        public RoomController(IRoomService roomService)
        {
            this.roomService = roomService;
        }
        public IActionResult Index()
        {
            var rooms = roomService.GetAll();
            
            return View(rooms);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateRoomViewModel room)
        {
            roomService.Add(room);

            return RedirectToAction(nameof(Index));
        }
    }
}
