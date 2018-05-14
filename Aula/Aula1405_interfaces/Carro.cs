using System;

namespace Aula1405_interfaces
{
    class Carro : IMeioTransporte
    {
        public int Velocidade { get; set; }

        //chave para o objeto Marca
        public int MarcaID { get; set; }

        //Propriedade de navegação
        public virtual Marca _Marca { get; set; }

        public string Modelo { get; set; }
        

        public Carro()
        {
            Velocidade = 0;
        }
        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Desacelerar()
        {
            Velocidade -= 5;
        }

        public string ImprimirInfo()
        {
            return "Carro, velocidade atual: " + Velocidade;
        }
    }
}
