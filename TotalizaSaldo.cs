using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisBanco
{
    public class TotalizaSaldo
    {

        public double Totaliza { get; set; }

        public void Soma(Conta conta)
        {
            this.Totaliza += conta.Saldo;
        }
    }
}
