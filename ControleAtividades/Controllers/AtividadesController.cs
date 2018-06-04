using Controllers.DAO;
using Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    class AtividadesController
    {
        private Contexto contexto = new Contexto();   
        //Salvar
        public void SalvarUsuario(Atividade entity)
        {
            contexto.Atividades.Add(entity);
            contexto.SaveChanges();
        }
        //Editar
        public void EditarAtividade(Atividade entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        //BuscarID
        public Atividade BuscarAtividadeID(int AtividadeID)
        {
           return contexto.Atividades.Find(AtividadeID);
            
        }
        //Listar todos as atividades
        public List<Atividade> ListarTodasAtividades()
        {
            return contexto.Atividades.ToList();
        }
        //Listar por nome
        public List<Atividade> ListarPorNome(string nome)
        {
            //LINQ
            //var atividadesComNome = from a in contexto.Atividades
            //            where a.Nome == nome
            //            select a;
            //return atividadesComNome.ToList();

            //LAMBDA
            return contexto.Atividades.Where(a => a.Nome.ToLower() == nome.ToLower()).ToList();

        }
        //Excluir
        public void Excluir(int AtividadeID)
        {
            Atividade a = BuscarAtividadeID(AtividadeID);

            if (a != null)
            {
                //forma1
                contexto.Atividades.Remove(a);

                //forma2
                //contexto.Entry(a).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();

            }
        }

    }
}
