using System;

namespace Banco.Contas
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        //public double Saldo { get; private set; }
        public double Saldo { get; protected set; }//caso vai usar saldo na herança nao funciona se for private
        public Cliente Titular { get; internal set; }
        public static int numeroDeContas;
        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }
        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }      
        public abstract void Deposita(double valor);
        public abstract void Saca(double valor);//se foi sobrescrito com override depois então é virtual
        public override bool Equals(Object outro)
        {
            if (!(outro is Conta))
            {
                return false;
            }
            Conta outraConta = (Conta)outro;
            return this.Numero == outraConta.Numero;
        }
        public int Tipo { get; set; }
        public override string ToString()
        {
            return " " + this.Titular.Nome;
        }

    }

}



/*  public class TotalizadorDeContas
    {//capitulo 9
        public double ValorTotal { get; private set; }
        public void Adiciona(Conta conta)
        {
            ValorTotal += conta.Saldo;
            //conta.CalculaRendimento();
        }
    }*/