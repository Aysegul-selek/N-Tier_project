using Microsoft.AspNetCore.Mvc;
using DataLayer.EntityFramwork;
using BusinesLayer.Abstract;
using BusinesLayer.Concreate;

namespace konusarakogren.Controllers
{
    public class MArka : Controller
    {
        MarkaManager mg = new MarkaManager(new EfMarkaRepository());
        public IActionResult Index()
        {
            var values = mg.GetList();
            return View(values);
        }
    }
}
