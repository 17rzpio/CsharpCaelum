using Banco.Contas;

namespace Banco
{

    public class ContaPoupanca : Conta, ITributavel
    {
        public ContaPoupanca() : base() { }
        public double CalcularTributo()
        {
            return this.Saldo * 0.01;
        }
        public override void Saca(double valor)
        {
            //this.Saldo -= (valor + 0.1);
            if (valor < 0)
            {
                throw new System.ArgumentException();
            }
            
            else if (valor > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= (valor + 0.1);
            }
            // base.Saca(valor + 0.1);

            //if(valor + 0.1 <= this.Saldo)
            //{

            //  this.Saldo -= (valor + 0.1);
            //    return true
            //}else
            //{
            //    return false
            //}

        }
        public override void Deposita(double valor)//se foi sobrescrito com override depois então é virtual
        {
            // this.Saldo += (valor - 0.75);
            if (valor < 0)
            {
                throw new System.ArgumentException();
            }
            else
            {
                this.Saldo += valor - 0.75;
            }
        }
        
        public void CalculaRendimento()
        {

        }
    }
}

        

        
        
    
