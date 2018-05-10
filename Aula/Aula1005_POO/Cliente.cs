namespace Aula1005_POO
{
    class Cliente
    {
        //Atributo
        private string nome;
        private string cpf;

        //Propriedade
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }
    }
}
