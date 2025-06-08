using Microsoft.AspNetCore.Mvc;
using Taxi.Data;

namespace Taxi.Controllers
{
    public class UsersController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var users = context.Users.ToList();
            return View(users);
        }
    }
}
