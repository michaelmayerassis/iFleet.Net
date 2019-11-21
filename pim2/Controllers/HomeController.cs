using System;
using System.Collections.Generic;
using System.Linq;
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
        private new static int Ok = 0;
        private readonly EmpresaContext _context;

        public HomeController(EmpresaContext context)
        {
            _context = context;
        }

        // GET: Home/
        public IActionResult Home()
        {
            return View();
        }

        //GET : LoginPage/
        public IActionResult LoginPage()
        {
            if (User.Identity.IsAuthenticated)
            {
                var empresas = _context.Empresas.FirstOrDefault(e => e.email == User.Identity.Name);
                if (empresas == null)
                {
                     HttpContext.SignOutAsync();
                    return RedirectToAction("LoginPage");
                }
                Ok = empresas.Id;
                return RedirectToAction("UserPage");
            }
            return View();
        }


        [HttpPost]
        public IActionResult LoginPage(Empresa empresa)
        {  
            var empresas =  _context.Empresas.FirstOrDefault(e => e.email == empresa.email && e.senha == empresa.senha);

                    //aqui poderia ter alguma requisição para base de dados, estou usando dados estáticos para não complicar
            if (empresas != null) 
            {
                Ok = empresas.Id;
                Login(empresa);
                return RedirectToAction("UserPage");
            }
            else
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

        [Authorize]
        public IActionResult Pecas()
        {
            return RedirectToAction("Index", "Pecas");
        }

        [Authorize]
        public IActionResult Motoristas()
        {
            return RedirectToAction("Index", "Motoristas");
        }

        [Authorize]
        public IActionResult Veiculos()
        {
            return RedirectToAction("Index", "Veiculoes");
        }

        // GET: Empresas/Edit/5
        [Authorize]
        public  IActionResult Edit()
        {
            var empresa =  _context.Empresas.FirstOrDefault(e => e.Id == Ok);
            if (empresa == null)
            {
                return NotFound();
            }
            return View(empresa);
        }

        // POST: Empresas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit([Bind("Id,nome,CNPJ,telefone,email,endereco,numero,cidade,bairro,senha")] Empresa empresa)
        {
            int id = Ok;
            var empresas = await _context.Empresas.FirstOrDefaultAsync(e => (e.email == empresa.email || e.CNPJ == empresa.CNPJ) && e.Id != id);
            if (empresas != null)
            {
                ViewBag.Erro = "Email ou CNPJ já cadastrado!";
            }
            else
            {
                if (id != empresa.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(empresa);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!EmpresaExists(empresa.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(UserPage));
                }
            }
            return View(empresa);
        }

        // GET: Empresas/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete()
        {
            int id = Ok;
            var empresa = await _context.Empresas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        // POST: Empresas/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed()
        {
            int id = Ok;
            var empresa = await _context.Empresas.FindAsync(id);
            _context.Empresas.Remove(empresa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Home));
        }

        private bool EmpresaExists(int id)
        {
            return _context.Empresas.Any(e => e.Id == id);
        }

        // GET: Empresas
        [Authorize]
        public async Task<IActionResult> Lista()
        {
            return View(await _context.Empresas.ToListAsync());
        }

        // GET: Empresas/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresa = await _context.Empresas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        // GET: Empresas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Empresas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,nome,CNPJ,telefone,email,endereco,numero,cidade,bairro,senha")] Empresa empresa)
        {
            var empresas = await _context.Empresas.FirstOrDefaultAsync(e => e.email == empresa.email || e.CNPJ == empresa.CNPJ);
            if (empresas != null)
            {
                ViewBag.Erro = "Email ou CNPJ já cadastrado!";
            }
            else
            {
                if (ModelState.IsValid)
                {
                    _context.Add(empresa);
                    var a =_context;
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(LoginPage));
                }
            }
            return View(empresa);
        }
    }
}
