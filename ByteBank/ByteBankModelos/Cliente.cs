namespace ByteBank.ByteBankModelos
{
    public class Cliente
    {

        public string Nome { get; set; }
        private string _cpf;
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                // aqui entraria a lógica de validação do CPF
                _cpf = value;
            }
        }
        public string Profissao { get; set; }

    }
}
