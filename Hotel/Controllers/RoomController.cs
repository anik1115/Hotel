using Hotel.Models.Room;
using Hotel.Services;
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

        public IActionResult Delete(int id)
        {
            roomService.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var room = roomService.Get(id);

            return View(room);
        }

        [HttpPost]

        public IActionResult Edit(EditRoomViewModel room)
        {
            roomService.Edit(room);

            return RedirectToAction(nameof(Index));
        }
    }
}
