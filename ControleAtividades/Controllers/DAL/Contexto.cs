using Modelo;
using Modelos;

using System.Data.Entity;

namespace Controllers.DAO
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Atividade> Atividades { get; set; }
        public DbSet<Categoria> Categirias { get; set; }

    }
}
