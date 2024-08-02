namespace test.Modelos
{
    public class Cliente : IIdentificavel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Profissao { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public string Identificar()
        {
            return $"Cliente: {Nome}, CPF: {Cpf}";
        }
    }
}
