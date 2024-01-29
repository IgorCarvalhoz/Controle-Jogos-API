using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Controle_Jogos_API.Context;
using Controle_Jogos_API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;

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
        public IActionResult Editar(int id){
            var jogo = _context.Jogos.Find(id);
            if(jogo == null){
                return NotFound();
            }
            return View(jogo);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar (Jogo jogo){
            var jogoBanco = _context.Jogos.Find(jogo.ID);
            if (jogoBanco == null){
                return NotFound();
            }
            else{
                jogoBanco.Nome = jogo.Nome;
                jogoBanco.HorasJogadas = jogo.HorasJogadas;
                jogoBanco.AnoLancamento = jogo.AnoLancamento;
                jogoBanco.AnoJogado = jogo.AnoJogado;
                jogoBanco.Finalizado = jogo.Finalizado;
                jogoBanco.UltimaAtualizacao = jogo.UltimaAtualizacao;
                jogoBanco.Avaliar = jogo.Avaliar;
                _context.Jogos.Update(jogoBanco);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }         
        }
        public IActionResult Detalhes(int id){
            var jogo = _context.Jogos.Find(id);
            return View(jogo);
        }
         public IActionResult Avaliacao(int id){
            var jogo = _context.Jogos.Find(id);
            if (jogo is null){
                return NotFound();
            }
            return View(jogo);
        }
        [HttpPost]
            public IActionResult Avaliacao(int id, string avaliacao)
            {
                var jogo = _context.Jogos.Find(id);
                if (jogo == null)
                {
                    return NotFound();
                }
                jogo.Avaliar = avaliacao;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index)); 
            }
        [HttpGet, ActionName("Avaliacao")]
        public IActionResult AvaliacaoLista()
        {
            var jogosAvaliados = _context.Jogos.Where(j => j.Avaliar != null).ToList();
            return View(jogosAvaliados);
        }
    }
}

    