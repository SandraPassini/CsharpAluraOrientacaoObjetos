namespace ByteBank.Titular
{
    public class Cliente
    {
        //para criar de forma automatica a propriedade, basta digitar prop e clicar 2 vezes no tab
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public static int TotalClientesCadastrados { get; set; }

        public Cliente()
        {
            TotalClientesCadastrados = TotalClientesCadastrados + 1;
        }
    }
}