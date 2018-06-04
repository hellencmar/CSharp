using Controllers.DAO;
using Modelo;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    class UsuariosController
    {
        private Contexto contexto = new Contexto();
        
        //Salvar
        public void SalvarUsuario(Usuario entity)
        {
            contexto.Usuarios.Add(entity);
            contexto.SaveChanges();
        }
        //Editar
        public void EditarUsuario ( Usuario entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        //BuscarID
        public Usuario BuscarUsuarioID(int UsuarioID)
        {
            return contexto.Usuarios.Find(UsuarioID);
        }
        //Listar todos os usuarios 
        public List<Usuario> ListarTodosUsuarios()
        {
            return contexto.Usuarios.ToList();
        }
        //Listar por nome
        public List<Usuario> ListarPorNome(string nome)
        {
            return contexto.Usuarios.Where(a => a.Nome.ToLower() == nome.ToLower()).ToList();

        } 
        //Excluir
        public void Excluir (int UsuarioID)
        {
            Usuario a = BuscarUsuarioID(UsuarioID);

            if (a != null)
            {
               
                contexto.Entry(a).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();

            }

        }
        
         

    }
}
