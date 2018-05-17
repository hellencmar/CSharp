using Aula1705_Camadas.Views;
using System;

namespace Aula1705_Camadas
{
    class Program
    {
        static void Main(string[] args)
        {
            AtividadesView atividadesView = new AtividadesView();
            atividadesView.ExibirMenu();

            Console.ReadKey();
        }
    }
}
