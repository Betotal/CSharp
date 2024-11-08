using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_tarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_tarefas.Contexto
{
    public class TarefaItemContexto : DbContext
    {
        public TarefaItemContexto(DbContextOptions<TarefaItemContexto> options) : base(options)
        {

        }
        public DbSet<TarefaItem> Tarefas {get; set;} = null!;
    }
}