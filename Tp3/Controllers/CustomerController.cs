using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tp3.Models;
using Tp3.Repositories;

namespace Tp3.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly CustomerRepository _customerRepository;
        public CustomerController(CustomerRepository customerRepository, ApplicationDbContext db)
        {
            _db = db;
            _customerRepository = customerRepository;
        }

        public IActionResult Index()
        {
            //var customers = _db.customers.Include(m => m.Membershiptype).ToList();
            var customers = _customerRepository.GetAllCustomers();
            return View(customers);

        }

        public IActionResult Create()
        {
            var members = _db.membershiptypes.ToList();
            ViewBag.member = members.Select(members => new SelectListItem()
            {
                Text = members.Name,
                Value = members.Id.ToString()
            });
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer c)
        {

            if (!ModelState.IsValid)
            {
                ViewBag.Errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                var members = _db.membershiptypes.ToList();
                ViewBag.member = members.Select(members => new SelectListItem()
                {
                    Text = members.Name,
                    Value = members.Id.ToString()
                });
                return View();
            }
            //_db.customers.Add(c);
            //_db.SaveChanges();
            _customerRepository.CreateCustomer(c);
            return RedirectToAction(nameof(Index));

        }

    }
}
