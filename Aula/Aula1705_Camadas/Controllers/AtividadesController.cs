﻿using Aula1705_Camadas.Models;
using System.Collections.Generic;
using System.Linq;

namespace Aula1705_Camadas.Controllers
{
    class AtividadesController
    {
        //simular a tabela
        private static List<Atividade> ListaAtividades { get; set; } = new List<Atividade>();
        private static int ultimoIdUtilizado = 0;

        //Salvar
        public void Salvar (Atividade atividade)
        {
            atividade.AtividadeID = ultimoIdUtilizado++;
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
        //Buscar a atividade por nome 
        public List<Atividade> BuscarPorNome(string nome)
        {
            IEnumerable<Atividade> atividadesSelecionadas = new List<Atividade>();

            atividadesSelecionadas = from x in ListaAtividades
                                     where x.Nome.ToLower().Contains(nome.ToLower())
                                     select x;

            return atividadesSelecionadas.ToList();
        }
        //Buscar por status 
        public List<Atividade> BuscarAtivoInativo(bool ativo)
        {
            IEnumerable<Atividade> atividadesSelecionadas = new List<Atividade>();

            atividadesSelecionadas = from x in ListaAtividades
                                     where x.Ativo == ativo
                                     select x;

            return atividadesSelecionadas.ToList();
        }

    }
}
