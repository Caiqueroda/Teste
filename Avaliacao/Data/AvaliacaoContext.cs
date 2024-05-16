using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Avaliacao.Models;

namespace Avaliacao.Data
{
    public class AvaliacaoContext : DbContext
    {
        public AvaliacaoContext (DbContextOptions<AvaliacaoContext> options)
            : base(options)
        {
        }

        public DbSet<Avaliacao.Models.Aluno> Aluno { get; set; } = default!;
    }
}
