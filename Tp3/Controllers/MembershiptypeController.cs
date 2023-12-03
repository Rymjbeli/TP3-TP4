using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tp3.Models;


namespace Tp3.Controllers
{
    public class MembershiptypeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MembershiptypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var membershiptypes = _db.membershiptypes.ToList();
            return View(membershiptypes);
        }

    }
}
