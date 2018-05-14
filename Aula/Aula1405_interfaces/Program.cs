using System;
using System.Collections.Generic;

namespace Aula1405_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            Console.WriteLine("Carro");
            Console.WriteLine("Velocidade inicial: " + car.Velocidade);
            car.Acelerar();
            car.Acelerar();
            car.Desacelerar();
            Console.WriteLine("Velocidade atual: " + car.Velocidade);

            Console.WriteLine();
            Console.WriteLine();

            Onibus bus = new Onibus();
            Console.WriteLine("Onibus");
            Console.WriteLine("Velocidade inicial: " + bus.Velocidade);
            bus.Acelerar();
            bus.Acelerar();
            bus.Desacelerar();
            Console.WriteLine("Velocidade atual: " + bus.Velocidade);
            Console.WriteLine();

            AcelerarBastante(car);
            Console.WriteLine(car.ImprimirInfo());

            Console.WriteLine();

            AcelerarBastante(bus);
            Console.WriteLine(bus.ImprimirInfo());

            CriarRelacionamentos();
                    
            Console.ReadKey();
        }

        static void AcelerarBastante(IMeioTransporte meioTransporte)//injeção de dependencia, precisa chegar um objeto, no caso meio de transporte
        {
            for (int i = 0; i < 20; i++)
            {
                meioTransporte.Acelerar();
            }
        }

        static void CriarRelacionamentos()
        {
            Carro c new Carro();
            c.Modelo = "Corsa";

            Marca m = new Marca();
            m.Nome = "Chevrolet";

            c._Marca = m;

            //criando e armazenando rodas 
            c.Rodas = new List<Roda>();
            Roda r1 = new Roda();
            c.Rodas.Add(r1);

            for (int i =0; i <3; i++)
            {
                c.Rodas.Add(new Roda());
            }

            Console.WriteLine("Qtd rodas: " + c.Rodas.Count);

            Onibus o = new Onibus();
            o.Modelo = "3100";

            o._Marca = m;
        }
    }
}
