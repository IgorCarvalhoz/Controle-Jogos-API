using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Controle_Jogos_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Controle_Jogos_API.Context
{
    public class JogosContext : DbContext
    {
        public JogosContext(DbContextOptions<JogosContext> options) : base(options){

        }
        public DbSet <Jogo> Jogos{get;set;}
    }
}