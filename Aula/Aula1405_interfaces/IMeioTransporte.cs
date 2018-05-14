

namespace Aula1405_interfaces
{
    interface IMeioTransporte
    {
        int Velocidade { get; set; }
        void Acelerar();
        void Desacelerar();
        string ImprimirInfo();

    }
}
