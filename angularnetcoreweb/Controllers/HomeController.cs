using angularnetcoreweb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace angularnetcoreweb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index ()
        {


            return View();
        }
        [HttpPost]
        public List<kullanici> GetList() {

            kullanici k = new kullanici();

            return k.KullaniciGetir();
        }
        
    }
}