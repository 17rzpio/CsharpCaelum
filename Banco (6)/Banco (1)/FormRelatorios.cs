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

namespace Banco
{
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;
      //  private List<Conta> contas;
     //   double total = 0;
        public FormRelatorios(List<Conta> contas)
        {

           // this.formPrincipal = formPrincipal;
            InitializeComponent();
            this.contas = contas;
            //this.contas = contas;
        }

        private void FormRelatorios_Load(object sender, EventArgs e)
        {

        }

        private void botaoFiltraSaldo_Click(object sender, EventArgs e)
        {


            //var resultado = from c in contas
            //                where c.Saldo > 2000
            //                select new { c.Numero, c.Titular };
            //foreach (var c in resultado)//foreach(var c in 
            //{
            //    MessageBox.Show(c.Titular.Nome + " " + c.Numero);
            //}
            listaResultados.Items.Clear();
            var resultado = from c in contas
                            where c.Saldo > 1000 && c.Numero < 10
                            select new { c.Numero, c.Titular };
            foreach (var c in resultado)//foreach(var c in 
            {
                listaResultados.Items.Add(c);
            }



        }

        private void botaoFiltraSaldo2_Click(object sender, EventArgs e)
        {
            listaResultados.Items.Clear();
            var resultado = contas
                            .Where(c => c.Saldo > 5000)
                            .OrderBy(c => c.Titular.Nome)
                            .ThenBy(c => c.Numero);
            foreach (var c in resultado)//foreach(var c in 
            {
                listaResultados.Items.Add(c);
            }
            double saldoTotal = resultado.Sum(conta => conta.Saldo);
            double maiorSaldo = resultado.Max(conta => conta.Saldo);
            double menorSaldo = resultado.Min(conta => conta.Saldo);
            labelSaldoTotal.Text = Convert.ToString(saldoTotal);
            labelSaldoMaior.Text = Convert.ToString(maiorSaldo);
            labelMenorSaldo.Text = Convert.ToString(menorSaldo);
            //listaResultados.Items.Clear();
            //var resultado = from c in contas
            //                where c.Saldo >5000
            //                orderby c.Titular.Nome descending, c.Numero descending
            //                select new { c.Numero, c.Titular, c.Saldo };
            //foreach (var c in resultado)//foreach(var c in 
            //{
            //    listaResultados.Items.Add(c);
            //}
            //double saldoTotal = resultado.Sum(conta => conta.Saldo);
            //double maiorSaldo = resultado.Max(conta => conta.Saldo);
            //double menorSaldo = resultado.Min(conta => conta.Saldo);
            //labelSaldoTotal.Text = Convert.ToString(saldoTotal);
            //labelSaldoMaior.Text = Convert.ToString(maiorSaldo);
            //labelMenorSaldo.Text = Convert.ToString(menorSaldo);

        }
    }
}

/*capitulo 21, lambda, função anonima, linq
 * ContaSimples novaConta = new ContaSimples();
            novaConta.Titular = new Cliente("a");
            novaConta.Numero = Convert.ToInt32(1);
            novaConta.Deposita(223000);
            this.contas.Add(novaConta);
            ContaSimples novaConta2 = new ContaSimples();
            novaConta2.Titular = new Cliente("ab");
            novaConta2.Numero = Convert.ToInt32(12);
            novaConta2.Deposita(30030);
            this.contas.Add(novaConta2);
            ContaSimples novaConta3 = new ContaSimples();
            novaConta3.Titular = new Cliente("ac");
            novaConta3.Numero = Convert.ToInt32(13);
            novaConta3.Deposita(30020);
            this.contas.Add(novaConta3);
            ContaSimples novaConta4 = new ContaSimples();
            novaConta4.Titular = new Cliente("qa");
            novaConta4.Numero = Convert.ToInt32(21);
            novaConta4.Deposita(1000);
            this.contas.Add(novaConta4);

            

            //var filtradas = contas.Where((Conta c) => { return c.Saldo > 2000; });
            //var filtradas = contas.Where(c => { return c.Saldo > 2000; });
            var filtradas = contas.Where(c => c.Saldo > 2000);

            //foreach(Conta c in contas)
            //{
            //    total += c.Saldo;
            //}
            
            foreach(Conta conta in filtradas)
            {
                
                MessageBox.Show(conta.Titular.Nome);
            }
            total = contas.Sum(c => c.Saldo);
            MessageBox.Show("soma de todos valores"+Convert.ToString(total));
            total = contas.Average(c => c.Saldo);
            MessageBox.Show("media de todos valores" + Convert.ToString(total));

            //numero de contas que possuem numero menor que 1000
            int numero = contas.Count(c => c.Numero < 1000);
            MessageBox.Show("numero de contas que possuem numero menor que 1000"+ Convert.ToString(numero));

            int menorNumero = contas.Min(c => c.Numero);
            MessageBox.Show("numero de contas que possuem numero menor que 1000" + Convert.ToString(menorNumero));

            double maiorSaldo = contas.Max(c => c.Saldo);
            MessageBox.Show("maior saldo"+ Convert.ToString(maiorSaldo));

            List<double> saldos = new List<double>();
            saldos.Add(3.14);
            saldos.Add(1.4);
            saldos.Add(1.75);
            double media = saldos.Average();
            MessageBox.Show("media"+Convert.ToString(media));

            var filtradas2 = from c in contas
                          where c.Saldo < 2000
                          select c;
            foreach (Conta conta in filtradas2)
            {

                MessageBox.Show(conta.Titular.Nome);
            }
            var resultado = from c in contas
                            where c.Saldo > 2000
                            select new { c.Numero, c.Titular };
            foreach(var c in resultado)//foreach(var c in 
            {
                MessageBox.Show(c.Titular.Nome+" "+c.Numero);
            }*/