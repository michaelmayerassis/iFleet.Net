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
        // GET: Home/Details/5
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult LoginPage()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("UserPage");
            }
            return View();
        }

        [HttpPost]
        public IActionResult LoginPage(Empresa empresa)
        {
            EmpresaDAO empresaDAO = new EmpresaDAO();

                    //aqui poderia ter alguma requisição para base de dados, estou usando dados estáticos para não complicar
            if (empresaDAO.RetornarLogin(empresa.email, empresa.senha)) 
            {
                Login(empresa);
                return RedirectToAction("UserPage");
            }else
                 {
                   ViewBag.Erro = "Usuário e / ou senha incorretos!";
                 }
            return View();
                
            
        }

        private async void Login(Empresa empresa)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, empresa.email),
                new Claim(ClaimTypes.Role, "Usuario_Comum")
            };

            var identidadeDeUsuario = new ClaimsIdentity(claims, "Login");
            ClaimsPrincipal claimPrincipal = new ClaimsPrincipal(identidadeDeUsuario);

            var propriedadesDeAutenticacao = new AuthenticationProperties
            {
                AllowRefresh = true,
                ExpiresUtc = DateTime.Now.ToLocalTime().AddHours(2),
                IsPersistent = true
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, propriedadesDeAutenticacao);
        }

        [Authorize]
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

       
        public IActionResult Empresas()
        {
            return RedirectToAction("Index", "Empresas");
        }

        public IActionResult CreateEmpresas()
        {
            return RedirectToAction("Create", "Empresas");
        }

        public IActionResult Motoristas()
        {
            return RedirectToAction("Index", "Motoristas");
        }

        public IActionResult Veiculos()
        {
            return RedirectToAction("Index", "Veiculoes");
        }
    }
}
