using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.DAL
{
    public partial class Contexto : DbContext
    {
        public Contexto() : base ("conn")
        {
            

        }

        public DbSet<User>  Usuarios { get; set; }
        public DbSet<Livros> Livros { get; set; }
        public DbSet<Emprestimos> Emprestimos { get; set; }
    }
}
