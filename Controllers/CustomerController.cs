using Microsoft.AspNetCore.Mvc;
using CustomerManagerApp.Models;
using CustomerManagerApp.Services;

namespace CustomerManagerApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerService _service;

        public CustomerController(CustomerService service)
        {
            _service = service;
        } 

        public IActionResult Index()
        {
            var customers = _service.GetAll();
            return View(customers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _service.Add(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var customers = _service.GetAll();
            if (id < 0 || id >= customers.Count) return NotFound();

            return View(customers[id]);
        }

        [HttpPost]
        public IActionResult Edit(int id, Customer customer)
        {
            if (ModelState.IsValid)
            {
                _service.Update(id, customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }
    }
}