using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;
using Banco.Busca;

namespace Banco
{
    public partial class FormCadasroConta : Form
    {
        private Form1 formPrincipal;

        public int indicetipo;

        /*  public FormCadastroConta(Form1 formPrincipal)
          {
              this.formPrincipal = formPrincipal;
              InitializeComponent();
          }*/

        //private ICollection<string> devedores;
        private ISet<string> devedores;
        
        public FormCadasroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }
        private void FormCadasroConta_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Conta simples");
            comboBox1.Items.Add("Conta corrente");
            comboBox1.Items.Add("Conta poupança");
            comboBox1.Items.Add("Conta investimento");

            textoNumero.Text = Convert.ToString(Conta.ProximoNumero());

        }

        private void butaoCadastro_Click(object sender, EventArgs e)
        {//capitulo 12
            if (indicetipo == 0)
            {
                //string titular = textoTitular.Text;
                //bool ehDevedor = false;
                //for(int i=0; i<30000; i++)
                //{
                //    ehDevedor = this.devedores.Contains(titular);
                //}
                //if (!ehDevedor)
                //{

                //    ContaSimples novaConta = new ContaSimples();
                //    novaConta.Titular = new Cliente(textoTitular.Text);
                //    // novaConta.Numero = Convert.ToInt32(textoNumero.Text);


                //    this.formPrincipal.AdicionaConta(novaConta);

                //}
                //else
                //{
                //    MessageBox.Show("é devedor");
                //}
                string titular = textoTitular.Text;
                bool ehDevedor = this.devedores.Contains(titular);
                if (!ehDevedor)
                {

                    ContaSimples novaConta = new ContaSimples();
                    novaConta.Titular = new Cliente(textoTitular.Text);
                    // novaConta.Numero = Convert.ToInt32(textoNumero.Text);


                    this.formPrincipal.AdicionaConta(novaConta);

                }
                else
                {
                    MessageBox.Show("é devedor");
                }
            }
            else if (indicetipo == 1)
            {
                string titular = textoTitular.Text;
                bool ehDevedor = this.devedores.Contains(titular);
                if (!ehDevedor)
                {

                    ContaCorrente novaConta = new ContaCorrente();
                    novaConta.Titular = new Cliente(textoTitular.Text);
                    // novaConta.Numero = Convert.ToInt32(textoNumero.Text);


                    this.formPrincipal.AdicionaConta(novaConta);

                }
                else
                {
                    MessageBox.Show("é devedor");
                }
            }
            else if (indicetipo == 2) 
            {
                string titular = textoTitular.Text;
                bool ehDevedor = this.devedores.Contains(titular);
                if (!ehDevedor)
                {

                    ContaPoupanca novaConta = new ContaPoupanca();
                    novaConta.Titular = new Cliente(textoTitular.Text);
                    // novaConta.Numero = Convert.ToInt32(textoNumero.Text);


                    this.formPrincipal.AdicionaConta(novaConta);

                }
                else
                {
                    MessageBox.Show("é devedor");
                }
            }
            else
            {
                string titular = textoTitular.Text;
                bool ehDevedor = this.devedores.Contains(titular);
                if (!ehDevedor)
                {

                    ContaInvestimento novaConta = new ContaInvestimento();
                    novaConta.Titular = new Cliente(textoTitular.Text);
                    // novaConta.Numero = Convert.ToInt32(textoNumero.Text);


                    this.formPrincipal.AdicionaConta(novaConta);

                }
                else
                {
                    MessageBox.Show("é devedor");
                }
            }
            textoNumero.Text = Convert.ToString(Conta.ProximoNumero());
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indicetipo = comboBox1.SelectedIndex;


            /*Conta selecionada = this.contas3[indice];
            textTitular.Text = selecionada.Titular.Nome;
                textSaldo.Text = Convert.ToString(selecionada.Saldo);
                textNumero.Text = Convert.ToString(selecionada.Numero);*/

        }

        private void botaoVisualizar_Click(object sender, EventArgs e)
        {
            // foreach (Conta conta in conta3)

        }


       
    }
    public class ContaSimples : Conta, ITributavel
    {
        public ContaSimples() : base() { }
        public double CalcularTributo()
        {
            return this.Saldo * 0.03;
        }
        public override void Deposita(double valor)
        {
            this.Saldo += (valor - 0.3);
        }

        public override void Saca(double valor)//se foi sobrescrito com override depois então é virtual
        {
            this.Saldo -= (valor + 0.75);
        }
    }
}
