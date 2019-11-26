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
    public class MotoristasController : Controller
    {
        private readonly MotoristaContext _context;

        public MotoristasController(MotoristaContext context)
        {
            _context = context;
        }
        public IActionResult Home()
        {
            return RedirectToAction("Home", "Home");
        }

        public IActionResult UserPage()
        {
            return RedirectToAction("UserPage", "Home");
        }
        // GET: Motoristas
        public IActionResult Index(string cpf)
        {
            var motoristas1 = _context.Motoristas.ToList();
            List<Motorista> motoristas = new List<Motorista>();
            motoristas = motoristas1;
            if (!String.IsNullOrEmpty(cpf))
            {
                foreach (Motorista item in motoristas1.ToList())
                {
                    motoristas.Remove(item);
                }
                motoristas.Add(_context.Motoristas.FirstOrDefault(m => m.CPF == cpf));
                ViewBag.Todos = 1;
            }
            else
            {
                motoristas = motoristas1;
                ViewBag.Todos = 0;
            }
            ViewBag.Id = motoristas;
            return View(motoristas);
        }

        // GET: Motoristas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorista = await _context.Motoristas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (motorista == null)
            {
                return NotFound();
            }

            return View(motorista);
        }

        // GET: Motoristas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Motoristas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CPF,Nome,CNH,Categoria_Cnh,Dt_Nascimento,Exame_medico,email,endereco,numero,cidade,Bairro,CEP")] Motorista motorista)
        {
            if (IsCpf(motorista.CPF))
            {
                var motoristas = await _context.Motoristas.FirstOrDefaultAsync(m => m.CPF == motorista.CPF || m.CNH == motorista.CNH);
                motorista.CPF = motorista.CPF.Replace(".", "").Replace("-", "");
                if (motoristas != null)
                {
                    ViewBag.Erro = "CPF ou CNH já cadastrado!";
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        _context.Add(motorista);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            ViewBag.Cpf = "CPF inválido";
            return View(motorista);
        }

        // GET: Motoristas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorista = await _context.Motoristas.FindAsync(id);
            if (motorista == null)
            {
                return NotFound();
            }
            return View(motorista);
        }

        // POST: Motoristas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CPF,Nome,CNH,Categoria_Cnh,Dt_Nascimento,Exame_medico,email,endereco,numero,cidade,Bairro,CEP")] Motorista motorista)
        {
            if (IsCpf(motorista.CPF))
            {
                var motoristas = await _context.Motoristas.FirstOrDefaultAsync(m => (m.CPF == motorista.CPF || m.CNH == motorista.CNH) && m.Id != id);
                if (motoristas != null)
                {
                    ViewBag.Erro = "CPF ou CNH já cadastrado!";
                }
                else
                {
                    if (id != motorista.Id)
                    {
                        return NotFound();
                    }

                    if (ModelState.IsValid)
                    {
                        try
                        {
                            _context.Update(motorista);
                            await _context.SaveChangesAsync();
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            if (!MotoristaExists(motorista.Id))
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
            }
            ViewBag.Cpf = "CPF inválido";
            return View(motorista);
        }

        // GET: Motoristas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorista = await _context.Motoristas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (motorista == null)
            {
                return NotFound();
            }

            return View(motorista);
        }

        // POST: Motoristas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var motorista = await _context.Motoristas.FindAsync(id);
            _context.Motoristas.Remove(motorista);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotoristaExists(int id)
        {
            return _context.Motoristas.Any(e => e.Id == id);
        }

        public bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
