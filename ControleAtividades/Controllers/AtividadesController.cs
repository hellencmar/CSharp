using Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    class AtividadesController
    {
        private List<Atividade> listAtividade { get; set; } = new List<Atividade>();
        private static int UltimoAtividadeID = 1;
        //Salvar
        public void SalvarUsuario(Atividade atividade)
        {
            atividade.AtividadeID= UltimoAtividadeID++;
            listAtividade.Add(atividade);
        }
        //Editar
        public void EditarAtividade(int AtividadeID, Atividade atividadeAtualizada)
        {
           Atividade atividadeAntiga = BuscarAtividadeID(AtividadeID);

            if (atividadeAntiga != null)
            {
                atividadeAntiga.Nome        = atividadeAtualizada.Nome;
                atividadeAntiga.Descricao   = atividadeAtualizada.Descricao;
                atividadeAntiga.UsuarioID   = atividadeAtualizada.UsuarioID;
                atividadeAntiga.CategoriaID = atividadeAtualizada.CategoriaID;
                atividadeAntiga.Ativo       = atividadeAtualizada.Ativo;
            }
        }
        //BuscarID
        public Atividade BuscarAtividadeID(int AtividadeID)
        {
            foreach (Atividade a in listAtividade)
            {
                if (a.AtividadeID == AtividadeID)
                    return a;
            }

            return null;
        }
        //Listar todos os usuarios 
        public List<Atividade> ListarTodasAtividades()
        {
            return listAtividade;
        }
        //Listar por nome
        public List<Atividade> ListarPorNome(string nome)
        {
            IEnumerable<Atividade> atividadesSelecionadas = new List<Atividade>();

            atividadesSelecionadas = from x in listAtividade
                                       where x.Nome.ToLower().Contains(nome.ToLower())
                                       select x;

            return atividadesSelecionadas.ToList();

        }
        //Excluir
        public void Excluir(int AtividadeID)
        {
           Atividade atividade = BuscarAtividadeID(AtividadeID);

            if (atividade != null)
               listAtividade.Remove(atividade);

        }

    }
}
