using System;

namespace Aula1005_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Cliente();

            cli.Nome = "Godofredo"; //set
            string nomeCliente = cli.Nome; //get

            cli.Cpf = "12345678909"; //set
            string cpfCliente = cli.Cpf; //get

            Console.WriteLine(cli.Nome);
            Console.WriteLine(cli.Cpf);

            // Utilizando os construtores parametrizados
            Cliente cli2 = new Cliente("Jucicreia"); //nome
            Console.WriteLine("cli2.Nome: " + cli2.Nome);

            Cliente cli3 = new Cliente("Juciliuda", "123"); //nome, cpf


            Pessoa c = new Cliente();
            Cliente c2 = (Cliente)c; // cast

            Console.WriteLine();

            //classes abstratas nao podem ser instanciadas
            //Pessoa p = new Pessoa();          
            Console.ReadKey();
        }
    }
}
