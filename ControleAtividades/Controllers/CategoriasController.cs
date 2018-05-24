using Modelo;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class CategoriasController
    {
        private List<Categoria> listCategoria = new List<Categoria>();
        private static int UltimoCategoriaID = 1;

        //Salvar
        public void SalvarCategoria(Categoria categoria)
        {
            categoria.CategoriaID = UltimoCategoriaID++;
            listCategoria.Add(categoria);
        }
        //Editar
        public void EditarCategoria(int CategoriaID, Categoria categoriaAtualizada)
        {
          Categoria categoriaAntiga = BuscarCategoriaID(CategoriaID);

            if (categoriaAntiga != null)
            {
                categoriaAntiga.Nome  = categoriaAtualizada.Nome;
                categoriaAntiga.Ativo = categoriaAtualizada.Ativo;
            }
        }
        //Listar todos 
        public List<Categoria> ListarTodasCategoria()
        {
            return listCategoria;
        }
        //Listar por nome
        public List<Categoria> ListarPorNome(string nome)
        {
            IEnumerable<Categoria> categoriasSelecionadas = new List<Categoria>();

            categoriasSelecionadas = from x in listCategoria
                                   where x.Nome.ToLower().Contains(nome.ToLower())
                                   select x;

            return categoriasSelecionadas.ToList();

        } 
        //BuscarID
        public Categoria BuscarCategoriaID(int CategoriaID)
        {
            foreach (Categoria a in listCategoria)
            {
                if (a.CategoriaID == CategoriaID)
                    return a;
            }

            return null;
        }
        //Excluir
        public void Excluir(int CategoriaID)
        {
           Categoria categoria = BuscarCategoriaID(CategoriaID);

            if (categoria != null)
                listCategoria.Remove(categoria);

        }

    }
}
