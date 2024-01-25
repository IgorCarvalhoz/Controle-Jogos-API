using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_Jogos_API.Entities
{
    public class Jogo
    {
        public int ID {get; set;}
        public string? Nome { get; set; }
        public double HorasJogadas {get;set;}
        public string? AnoLancamento {get;set;}
        public int AnoJogado {get; set;}
        public bool Finalizado{get; set;}
    }
}