using Microsoft.AspNetCore.Mvc;
using MvcProje.Models.Entity;
using MvcProje.Repositories;

namespace MvcProje.Controllers
{
	public class AboutController : Controller
	{
		GenericRepository<About> repository=new GenericRepository<About>();	
		public IActionResult Index()
		{
			var about = repository.List();
			return View(about);
		}
	}
}
