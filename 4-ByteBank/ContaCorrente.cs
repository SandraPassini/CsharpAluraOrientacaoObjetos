namespace ByteBank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;

        //public bool Sacar(double valor)
        //{
        //    if (saldo < valor)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        saldo = saldo - valor;
        //        return true;
        //    }
        //}

        //metodo SACAR
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
    }
}