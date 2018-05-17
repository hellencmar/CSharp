using Aula1705_Camadas.Models;
using System.Collections.Generic;

namespace Aula1705_Camadas.Controllers
{
    class AtividadesController
    {
        //simular a tabela
        public List<Atividade>  ListaAtividades { get; set; 

        //Salvar
        public void Salvar (Atividade atividade)
        {
            ListaAtividades.Add(atividade);
        }
        //Listar
        //Editar
        //Excluir
    }
}
