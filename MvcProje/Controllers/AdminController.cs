using Microsoft.AspNetCore.Mvc;
using MvcProje.Models.Entity;
using MvcProje.Repositories;

namespace MvcProje.Controllers
{
    public class AdminController : Controller
    {
        GenericRepository<Animal> repository = new GenericRepository<Animal>();
        public IActionResult Index()
        {
            var animals = repository.List();
            return View(animals);
        }
        [HttpGet]
        public IActionResult AnimalAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AnimalAdd(Animal p)
        {
            repository.TAdd(p);
            return RedirectToAction("Index"); //admin controller daki index metoduna gönderme yani yukarı
        }
        public IActionResult AnimalDelete(int id)
        {
            Animal a=repository.Find(x=> x.AnimalID==id);
            repository.TDelete(a);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AnimalUpdate(int id)
        {
            Animal a=repository.Find(x=>x.AnimalID==0); 
            return View(a);

        }

    }
}
