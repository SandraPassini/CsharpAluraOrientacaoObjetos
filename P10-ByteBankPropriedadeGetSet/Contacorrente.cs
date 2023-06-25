using ByteBank.Titular;

namespace ByteBank
{
    public class ContaCorrente
    {
        private double saldo;
        public Cliente Titular { get; set; }
        public string Conta { get; set; }
        public int Numero_agencia { get; set; }
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
    }
}