using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta conta;
        public Form1()
        {
            InitializeComponent();
            textTitular.Text = "Texto da minha caixa de texto";
        }
        private void textTitular_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.Numero = 1;
            Cliente cliente = new Cliente("rodrigo Pioner");
            c.Titular = cliente;

            textTitular.Text = c.Titular.Nome; 
            textNumero.Text = Convert.ToString(c.Numero);
            textSaldo.Text = Convert.ToString(c.Saldo);

            this.conta = new Conta();
        

           
            
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.conta.Deposita(valorOperacao);
            textSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Sucesso!!!");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.conta.Saca(valorOperacao);
            textSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void butaoTeste_Click(object sender, EventArgs e)
        {//capitulo 9
            Cliente teste = new Cliente("rodrigo Pioner") { Idade = 30, Documentos = "", CPF = "1" };
            
            if (teste.PodeAbrirContaSozinho)
            {
                MessageBox.Show("Sim");
            }
            else
            {
                MessageBox.Show("nao");
            }
        }
    }
}
