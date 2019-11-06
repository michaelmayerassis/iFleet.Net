using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pim2.Models;

namespace pim2.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmpresaContext _context;

        public HomeController(EmpresaContext context)
        {
            _context = context;
        }

        // GET: Home/Details/5
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult LoginPage()
        {

            return View();
        }

        [HttpPost]
        public IActionResult LoginPage(Empresa empresa)
        {
            EmpresaDAO empresaDAO = new EmpresaDAO();

                    //aqui poderia ter alguma requisição para base de dados, estou usando dados estáticos para não complicar
            if (empresaDAO.RetornarLogin(empresa.email, empresa.senha)) 
            {
                return RedirectToAction("UserPage");
            }else
                 {
                   ViewBag.Erro = "Usuário e / ou senha incorretos!";
                 }
            return View();
                
            
        }

       
        public IActionResult UserPage()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Home");
        }

        public IActionResult Pecas()
        {
            return RedirectToAction("Index", "Pecas");
        }

       
        public IActionResult CreateEmpresa()
        {
            return RedirectToAction("Index", "Empresas");
        }
    }
}
