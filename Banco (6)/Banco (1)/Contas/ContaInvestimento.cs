using Banco.Contas;

namespace Banco
{
    public class ContaInvestimento : Conta, ITributavel
    {
        public ContaInvestimento() : base() { }
        public double CalcularTributo()
        {
            return this.Saldo * 0.02;
        }
        public override void Saca(double valor)
        {

            // base.Saca(valor + 0.1);


            this.Saldo -= (valor + 0.9);

        }
        public override void Deposita(double valor)//se foi sobrescrito com override depois então é virtual
        {
            this.Saldo += (valor - 0.95);
        }
        
        
    }
}