using dotnet_mvc_ef_core.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_ef_core.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<CustomerEntity> customers = _context.CustomerEntities.ToList();
            return View(customers);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            CustomerEntity customer = _context.CustomerEntities.Find(id);
            return View(customer);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("Name, Address, Gender, City")] CustomerEntity request)
        {
            // add ke entity
            _context.CustomerEntities.Add(request);
            // commit to database
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.CustomerEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.CustomerEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }
            // remove from entity
            _context.CustomerEntities.Remove(entity);
            // commit to database
            _context.SaveChanges();
            return Redirect("/Category/GetAll");
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, Name, Address, Gender, City")] CustomerEntity request)
        {
            // update entity
            _context.CustomerEntities.Update(request);
            // commit to database
            _context.SaveChanges();
            return Redirect("GetAll");
        }
    }
}
