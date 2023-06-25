using ByteBank.Titular;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        private double saldo;

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
                Console.WriteLine("ValorSacar: " + valor);
                saldo = saldo - valor;
                Console.WriteLine("SaldoSacar: " + saldo);
                return true;
            }
        }


        //Metodo Depositar
        //metodo void nao retorna valor, ou seja vc depositou e nao aguarda confirmacao
        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }
        //Metodo por ser public torna o campo saldo public
        public void DefinirSaldo(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor menor que zero");
                return;
            }
            saldo = valor;

            Console.WriteLine(saldo);
        }

        public double ObterSaldo()
        {
            return saldo;
        }
    }
}