using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pim2.Models;

namespace iFleetWeb.Controllers
{
    [Authorize]
    public class PecasController : Controller
    {
        private readonly PecaContext _context;

        public PecasController(PecaContext context)
        {
            _context = context;
        }

        // GET: Pecas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pecas.ToListAsync());
        }

        public IActionResult UserPage()
        {
            return RedirectToAction("UserPage", "Home");
        }

        // GET: Pecas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peca = await _context.Pecas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (peca == null)
            {
                return NotFound();
            }

            return View(peca);
        }

        // GET: Pecas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pecas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Id,Descricao,Prateleira,Quantidade,EstoqueMinimo,Valor")] Peca peca)
        {
            var pecas = await _context.Pecas.FirstOrDefaultAsync(a => a.Nome == peca.Nome);
            if (pecas != null)
            {
                ViewBag.Erro = "já contém está peça cadastrada!";
            }
            else
            {
                if (ModelState.IsValid)
                {
                    _context.Add(peca);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(peca);
                
        }

        // GET: Pecas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peca = await _context.Pecas.FindAsync(id);
            if (peca == null)
            {
                return NotFound();
            }
            return View(peca);
        }

        // POST: Pecas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nome,Id,Descricao,Prateleira,Quantidade,EstoqueMinimo,Valor")] Peca peca)
        {
            var pecas = await _context.Pecas.FirstOrDefaultAsync(a => a.Nome == peca.Nome && a.Id != id);
            if (pecas != null)
            {
                ViewBag.Erro = "já contém está peça cadastrada!";
            }
            else
            {
                if (id != peca.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(peca);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!PecaExists(peca.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(peca);
        }

        // GET: Pecas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peca = await _context.Pecas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (peca == null)
            {
                return NotFound();
            }

            return View(peca);
        }

        // POST: Pecas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var peca = await _context.Pecas.FindAsync(id);
            _context.Pecas.Remove(peca);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PecaExists(int id)
        {
            return _context.Pecas.Any(e => e.Id == id);
        }
    }
}
