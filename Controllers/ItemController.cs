using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ZipShare.Controllers
{
    public class ItemController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddItem()
        {
            return View();
        }

        public IActionResult RemoveItem()
        {
            return View();
        }
    }
}