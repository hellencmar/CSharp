using System.Collections.Generic;

namespace Aula1405_interfaces
{
    class Roda
    {
        public int RodaID { get; set; }
        public string Modelo { get; set; }
        public int MarcaID { get; set; }
        public Marca _Marca { get; set; }
        public List<Roda> Rodas;
    }
}
