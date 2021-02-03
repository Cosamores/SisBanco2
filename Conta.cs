using System;
using System.Runtime.CompilerServices;

namespace SisBanco
{
    public partial class Conta
    {

        public Conta()
        {
        }

        public Conta(int numero)
        {
            Numero = numero;
        }

        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }
        //public int TipoDeConta { get; set; } //1-conta corrente 2-conta poupança

        public double Depositar(double valor)
        {
            return this.Saldo += valor;
        }

        public virtual double Sacar(double valor)
        {
            return this.Saldo -= valor;
        }

    }
}