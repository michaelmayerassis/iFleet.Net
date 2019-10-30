using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pim2.Models;

namespace pim2.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home/Details/5
        public async Task<IActionResult> Home()
        {
            return View();
        }

        public IActionResult Pecas()
        {
            return RedirectToAction("Index", "Pecas");
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }

        public IActionResult CreateEmpresa()
        {
            return RedirectToAction("Index", "Empresas");
        }
    }
}
