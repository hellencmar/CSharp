using System;

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
                    
            Console.ReadKey();
        }

        static void AcelerarBastante(IMeioTransporte meioTransporte)//injeção de dependencia, precisa chegar um objeto, no caso meio de transporte
        {
            for (int i = 0; i < 20; i++)
            {
                meioTransporte.Acelerar();
            }
        }
    }
}
