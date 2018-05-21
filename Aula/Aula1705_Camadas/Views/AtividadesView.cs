using Aula1705_Camadas.Controllers;
using Aula1705_Camadas.Models;
using System;

namespace Aula1705_Camadas.Views
{
    class AtividadesView
    {
        //enum OpcoesMenu
        //{
        //    CriarAtividade = 1,
        //    ListarAtividades = 2,
        //    BuscarAtividade = 3,
        //    EditarAtividade = 4,
        //    ExcluirAtividade = 5,
        //    BuscarPorNome = 6,
        //    ListarPorStatus = 7,
        //    Sair = 9
        //}
        public void ExibirMenu()
        {
            int opcao =9 ;
            do
            {
                Console.Clear();
                Console.WriteLine("=========================================");
                Console.WriteLine("=  Escolha uma opcao:                   =");
                Console.WriteLine("= 1) Criar Atividade                    =");
                Console.WriteLine("= 2) Listar Atividades                  =");
                Console.WriteLine("= 3) Buscar Atividade                   =");
                Console.WriteLine("= 4) Editar Atividade                   =");
                Console.WriteLine("= 5) Excluir Atividade                  =");
                Console.WriteLine("= 6) Buscar atividade por nome          =");
                Console.WriteLine("= 7) Listar Atividades (Ativos/Inativos)=");
                Console.WriteLine("= 9) Sair                               =");
                Console.WriteLine("=========================================");


               //opcao = (OpcoesMenu)int.Parse(Console.ReadLine());
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CriarAtividade();
                        break;
                    case 2:
                        ListarAtividades();
                        break;
                    case 3:
                        BuscarAtividade();
                        break;
                    case 4:
                        EditarAtividade();
                        break;
                    case 5:
                        ExcluirAtividade();
                        break;
                    case 6:
                        BuscarAtividadePorNome();
                        break;
                    case 7:
                        ListarAtividadePorStatus();
                         break;

                        default:
                        break;
                }
        } while (opcao != 9);
        }
        public void CriarAtividade()
        {
            Atividade atividade = new Atividade();
            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();
            atividade.Ativo = true;

            AtividadesController atividadeCtrl = new AtividadesController();
            atividadeCtrl.Salvar(atividade);
        }
        private void ListarAtividades()
        {
            Console.WriteLine("Listando atividades cadastradas");
            AtividadesController atividadeController = new AtividadesController();
            foreach (Atividade atividade in atividadeController.Listar())
            {
                ExibirDetalhesAtividade();
            }
            Console.WriteLine("Fim da lista");
            Console.ReadKey();

        }
        private void EditarAtividade()
        {
            ListarAtividades();

            Console.Write("Digite o id da atividade que deseja editar: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividadeAtualizada = ObterDadosAtividade();

            AtividadesController atividadeController = new AtividadesController();
            atividadeController.Editar(id, atividadeAtualizada);
        }
        private void ExcluirAtividade()
        {
            ListarAtividades();

            Console.Write("Digite o id da atividade que deseja excluir: ");
            int id = int.Parse(Console.ReadLine());

            AtividadesController atividadeController = new AtividadesController();
            atividadeController.Excluir(id);
        }     
        private void BuscarAtividade()
        {
            AtividadesController atividadeController = new AtividadesController();

            Console.Write("Digite o id da atividade: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividade = atividadeController.BuscarPorID(id);

            if (atividade != null)
            {
                ExibirDetalhesAtividade(atividade);
            }
            else
            {
                Console.WriteLine("Atividade não encontrada");
            }

            Console.ReadKey();
        }      
        private void BuscarAtividadePorNome()
        {
            AtividadesController atividadeController = new AtividadesController();

            Console.Write("Digite o nome da atividade: ");
            string nomeAtividade = Console.ReadLine();
            Console.WriteLine("-------- Exibindo ativade(s) buscada(s) ------")
            foreach (Atividade atividade in atividadeController.BuscarPorNome(nomeAtividade))
            {
                ExibirDetalhesAtividade();
            }
            Console.WriteLine("----- Fim da lista buscada -----");
            Console.ReadKey();
        }
        private void ListarAtividadePorStatus()
        {       
         
            AtividadesController atividadeController = new AtividadesController();

            Console.WriteLine("Deseja listar as ativas ou inativas? (a/i)");
            bool status = Console.ReadLine() == "a" ? true : false;
            Console.WriteLine("-------- Exibindo ativade(s) buscada(s) ------")
            foreach (Atividade atividade in atividadeController.BuscarPorStatus(status))
            {
                ExibirDetalhesAtividade();
            }
            Console.WriteLine("-------- Fim da lista buscada ------")
            Console.ReadKey();

        }
        private static Atividade ObterDadosAtividade()
        {
            Atividade atividade = new Atividade();

            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();

            Console.Write("Ativo? (s/n): ");
            atividade.Ativo = Console.ReadLine() == "s" ? true : false;           
            return atividade;
        }
        private void ExibirDetalhesAtividade()
        {
            Console.WriteLine("---");
            Console.WriteLine("Id: " + atividade.AtividadeID);
            Console.WriteLine("Nome: " + atividade.Nome);
            Console.WriteLine("Ativo: " + atividade.Ativo);
            Console.WriteLine("---");
        }
        private static void ExibirDetalhesAtividade(Atividade atividade)
        {
            Console.WriteLine("---");
            Console.WriteLine("Id: " + atividade.AtividadeID);
            Console.WriteLine("Nome: " + atividade.Nome);
            Console.WriteLine("Ativo: " + atividade.Ativo);
            Console.WriteLine("---");
        }

    }
}
