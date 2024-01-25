using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Controle_Jogos_API.Context;
using Controle_Jogos_API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Controle_Jogos_API.Controllers
{
    public class JogoController : Controller
    {
        private readonly JogosContext _context;
        public JogoController(JogosContext context){
        _context = context;
        }
        public IActionResult Index(){
            var jogo = _context.Jogos.ToList();
            return View(jogo);
        }
        public IActionResult Adicionar(){
            return View();
        }
        [HttpPost]
        public IActionResult Adicionar(Jogo jogo){
            _context.Jogos.Add(jogo);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index)); 
        }
        public IActionResult Remover(int id){
            var jogo = _context.Jogos.Find(id);
            if (jogo is null){
            return NotFound();
        }
        return View(jogo);
      }
        [HttpPost, ActionName("Remover")]
        public IActionResult RemoverConfirmado(int id){
            var jogo = _context.Jogos.Find(id);
            if (jogo == null){
                return NotFound();
            }
            _context.Jogos.Remove(jogo);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
    