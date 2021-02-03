namespace SisBanco
{
  
        class ContaPoupança : Conta
            {

        public ContaPoupança(int numero) : base (numero) { }
       
        public override double Sacar (double valor)
            {
            //  return this.Saldo -= valor + 0.10;

            return base.Sacar(valor + 0.10); //base traz o método do parent
            }

        }
}