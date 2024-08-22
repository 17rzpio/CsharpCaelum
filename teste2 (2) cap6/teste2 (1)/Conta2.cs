using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste2
{
    class Conta2
    {//capitulo 7
        public int Numero { get; set; }//auto implemented
        public double Saldo { get=>200; private set { } }
        
        
        public Cliente Titular { get; set; }
    }




        /* como funciona get e set
        private int numero;
        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }*/
        
        
        
        
        
        
        /* o que faz a propriedade que é para exibir ou entrar um valor privado
        * private double saldo;
        public double PegaSaldo()
        {
            return this.saldo;
        }
        private int numero;

        public void ColocaNumero(int numero)
        {
            this.numero = numero;
        }*/

            
        
    
    /*{//capitulo 6
        public double saldo;
        public int numero;
        public int idade;
        public Cliente titular;

        public bool Saca(double valor)
        {
            if (idade < 13)
            {
                this.saldo -= 200;
                return false;

            }
            else
            {
                this.saldo -= 1000;
                return true;
            }
        }
    }*/
    class Cliente
    {//capitulo 6
        public string nome;
        public string cpf;
        public string rg;
        public string endereco;
        public int idade2;

        public bool EhMaiorDeIdade()
        {
            if (idade2 > 18)
            {
                return true;
            }
            return false;
        }

    }
}
