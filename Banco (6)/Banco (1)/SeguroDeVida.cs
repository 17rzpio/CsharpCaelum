using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco
{

    public class SeguroDeVida : Conta,ITributavel
    {
        public SeguroDeVida() : base() { }
        
        public double CalcularTributo()
        {

            return this.Saldo+=42;
        }
        public override void Saca(double valor)
        {
        }
        public override void Deposita(double valor)
        {
            
        }
    }
}
