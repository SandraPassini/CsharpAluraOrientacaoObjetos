using ByteBank.Titular;

namespace ByteBank
{
    public class ContaCorrente
    {
        private double saldo;
        //propriedades
        public Cliente Titular { get; set; }

        private string _conta;

        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        //definicao de campo
        private int _numero_agencia;

        public int Numero_agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }
        public string Nome_agencia { get; set; }
        public double Saldo 
        { 
            get {
                return saldo;
                }
            set
                {
                    if (value <= 0)
                    {
                        return;
                    }
                    else 
                    saldo = value + 5.0;
            }         
        }

        public ContaCorrente(int numero_agencia, string conta)
        {
            Numero_agencia = numero_agencia;
            Conta = conta;
        }
    }
}