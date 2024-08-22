using Banco.Contas;

namespace Banco
{
    public class ContaCorrente : Conta, ITributavel
    {
        //public ContaCorrente() : base() { }
        private static int totalDeContas = 0;
        public ContaCorrente() {
            ContaCorrente.totalDeContas++;
        }
        public static int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }
        public double CalcularTributo()
        {
            return this.Saldo * 0.04;
        }
        public override void Deposita(double valor)
        {
            if (valor < 0)
            {
                throw new System.ArgumentException();
            }
            else
            {
                this.Saldo += valor - 0.95;
            }
        }
   
         
        public override void Saca(double valor)//se foi sobrescrito com override depois então é 
  
      
        {
   
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
  
                this.Saldo -= (valor + 0.2);
      
            }
  
        }

    }

}