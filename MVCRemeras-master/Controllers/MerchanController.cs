using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCMerchandising.Controllers
{
    public class MerchanController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()

        {

            return View();

        }


        public IActionResult Tienda(string name, int numTimes = 1)

        {

            ViewData["Message"] = "Hello " + name;

            ViewData["NumTimes"] = numTimes;


            return View();

        }
        public IActionResult Info()

        {

            return View();

        }
    }
}
