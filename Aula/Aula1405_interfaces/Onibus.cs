﻿using System;

namespace Aula1405_interfaces
{
    class Onibus : IMeioTransporte
    {
        public int Velocidade { get; set; }

        //chave para o objeto Marca
        public int MarcaID { get; set; }

        //Propriedade de navegação
        public virtual Marca _Marca { get; set; }

        public string Modelo { get; set; }
      

        public Onibus()
        {
            Velocidade = 0;
        }
        public void Acelerar()
        {
            Velocidade += 5;
        }

        public void Desacelerar()
        {
            Velocidade -= 3;
        }

        public string ImprimirInfo()
        {
            return "Onibus, velocidade atual: " + Velocidade;
        }
    }
}
