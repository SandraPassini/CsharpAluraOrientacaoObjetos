namespace ByteBank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;

        //metodo SACAR
        //metodo sacar retorna valor, pois vc esta sacando e aguarda confirmacao
        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Saldo menor que valor " + valor);
                return false;
            }
            if (valor <= 0)
            {
                Console.WriteLine("Valor menor ou igual a zero " + valor);
                return false;
            }
            else
            {
                Console.WriteLine("Valor: " + valor);
                saldo = saldo - valor;
                return true;
            }
        }


        //Metodo Depositar
        //metodo void nao retorna valor, ou seja vc depositou e nao aguarda confirmacao
        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }
    }
}