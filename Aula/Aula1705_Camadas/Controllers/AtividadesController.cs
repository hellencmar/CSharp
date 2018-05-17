﻿using Aula1705_Camadas.Models;
using System.Collections.Generic;

namespace Aula1705_Camadas.Controllers
{
    class AtividadesController
    {
        //simular a tabela
        private static List<Atividade> ListaAtividades { get; set; } = new List<Atividade>();

        //Salvar
        public void Salvar (Atividade atividade)
        {
            atividade.AtividadeID = ListaAtividades.Count + 1;
            ListaAtividades.Add(atividade);
        }
        //Listar
        public List<Atividade> Listar()
        {
            return ListaAtividades;
        }
        //BuscarPorID
        public Atividade BuscarPorID( int id)
        {
            foreach (Atividade a in ListaAtividades)
            {
                if (a.AtividadeID == id)
                    return a;
            }
            return null;
        }
        //Editar
        public void Editar(int id, Atividade atividadeAtualizada)
        {
            Atividade atividadeAntiga = BuscarPorID(id);

            if (atividadeAntiga != null)
            {
                atividadeAntiga.Nome = atividadeAtualizada.Nome;
                atividadeAntiga.Ativo = atividadeAtualizada.Ativo;
            }
        }
        //Excluir
        public void Excluir(int id)
        {
            Atividade atividade = BuscarPorID(id);
            if (atividade != null)
                ListaAtividades.Remove(atividade);
        }
    }
}
