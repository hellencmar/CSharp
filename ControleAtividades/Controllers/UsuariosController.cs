using Modelo;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    class UsuariosController
    {
        private List<Usuario> listUsuarios { get; set; } = new List<Usuario>();
        private static int UltimoUsuarioID = 1;
        //Salvar
        public void SalvarUsuario(Usuario usuario)
        {
            usuario.UsuarioID = UltimoUsuarioID++;
            listUsuarios.Add(usuario);
        }
        //Editar
        public void EditarUsuario (int UsuarioID, Usuario usuarioAtualizado)
        {
            Usuario usuarioAntigo = BuscarUsuarioID(UsuarioID);
            
            if(usuarioAntigo != null)
            {
                usuarioAntigo.Nome  = usuarioAtualizado.Nome;
                usuarioAntigo.Ativo = usuarioAtualizado.Ativo;
            }
        }
        //BuscarID
        public Usuario BuscarUsuarioID(int UsuarioID)
        {
            foreach (Usuario a in listUsuarios)
            {
                if (a.UsuarioID == UsuarioID)                
                    return a;                
            }

            return null;
        }
        //Listar todos os usuarios 
        public List<Usuario> ListarTodosUsuarios()
        {
            return listUsuarios;
        }
        //Listar por nome
        public List<Usuario> ListarPorNome(string nome)
        {
            IEnumerable<Usuario> usuariosSelecionados = new List<Usuario>();

            usuariosSelecionados = from x in listUsuarios
                                     where x.Nome.ToLower().Contains(nome.ToLower())
                                     select x;

            return usuariosSelecionados.ToList();

        } 
        //Excluir
        public void Excluir (int UsuarioID)
        {
            Usuario usuario = BuscarUsuarioID(UsuarioID);

            if (usuario != null)
                listUsuarios.Remove(usuario);

        }
        
         

    }
}
