﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pim2.Models;

namespace pim2.Controllers
{
    [Authorize]
    public class VeiculoesController : Controller
    {
        private readonly VeiculoContext _context;
        private readonly EmpresaContext _empresaContext;

        public VeiculoesController(VeiculoContext context, EmpresaContext empresaContext)
        {
            _context = context;
            _empresaContext = empresaContext;
        }
        public IActionResult Home()
        {
            return RedirectToAction("Home", "Home");
        }

        public IActionResult UserPage()
        {
            return RedirectToAction("UserPage", "Home");
        }

        // GET: Veiculoes
        public IActionResult Index()
        {
            var empresas = _empresaContext.Empresas.FirstOrDefault(e => e.email == User.Identity.Name);
            var veiculoContext = _context.Veiculo.Include(v => v.Empresa);
            List<Veiculo> veiculos = new List<Veiculo>();
            foreach (Veiculo item in veiculoContext)
            {
                if (item.Empresa.Id == empresas.Id)
                {
                    veiculos.Add(item);
                }
            }
            return View(veiculos);
        }

        // GET: Veiculoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculo = await _context.Veiculo
                .Include(v => v.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veiculo == null)
            {
                return NotFound();
            }

            return View(veiculo);
        }

        // GET: Veiculoes/Create
        public IActionResult Create()
        {
            var empresas = _empresaContext.Empresas.FirstOrDefault(e => e.email == User.Identity.Name);
            ViewBag.Result = empresas.Id;
            return View();
        }

        // POST: Veiculoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Empresa_Id,Nome,Cor,Modelo,Ano,Placa,Renavan,Marca")] Veiculo veiculo)
        {
            var veiculos = await _context.Veiculo.FirstOrDefaultAsync(v => v.Placa == veiculo.Placa || v.Renavan == veiculo.Renavan);
            if (veiculos != null)
            {
                ViewBag.Erro = "Renavan já cadastrado!";
            }
            else
            {
                if (ModelState.IsValid)
                {
                    _context.Add(veiculo);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            //ViewData["Empresa_Id"] = new SelectList(_context.Set<Empresa>(), "Id", "nome", veiculo.Empresa_Id);
            return View(veiculo);
        }

        // GET: Veiculoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculo = await _context.Veiculo.FindAsync(id);
            if (veiculo == null)
            {
                return NotFound();
            }
            ViewData["Empresa_Id"] = new SelectList(_context.Set<Empresa>(), "Id", "nome", veiculo.Empresa_Id);
            return View(veiculo);
        }

        // POST: Veiculoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Empresa_Id,Nome,Cor,Modelo,Ano,Placa,Renavan,Marca")] Veiculo veiculo)
        {
            var veiculos = await _context.Veiculo.FirstOrDefaultAsync(v => (v.Placa == veiculo.Placa || v.Renavan == veiculo.Renavan) && v.Id != id);
            if (veiculos != null)
            {
                ViewBag.Erro = "Renavan já cadastrado!";
            }
            else
            {
                if (id != veiculo.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(veiculo);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!VeiculoExists(veiculo.Id))
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
            ViewData["Empresa_Id"] = new SelectList(_context.Set<Empresa>(), "Id", "nome", veiculo.Empresa_Id);
            return View(veiculo);
        }

        // GET: Veiculoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculo = await _context.Veiculo
                .Include(v => v.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veiculo == null)
            {
                return NotFound();
            }

            return View(veiculo);
        }

        // POST: Veiculoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var veiculo = await _context.Veiculo.FindAsync(id);
            _context.Veiculo.Remove(veiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VeiculoExists(int id)
        {
            return _context.Veiculo.Any(e => e.Id == id);
        }
    }
}
