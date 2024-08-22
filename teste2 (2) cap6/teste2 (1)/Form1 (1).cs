using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste2
{

    public partial class Form1 : Form
    {
        int numeroDaConta = 1;
        public int valorSaque = 90;
        public int saldo = 500;
        int valor = 1;
        string message = "minha mensagem";
        string nome = "rodrigo";
        int idade1 = 10;
        int idade2 = 20;
        int idade3 = 30;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//exercicio capitulo 2
            saldo -= valorSaque;


            long valorGrande = valor;
            short valorPequeno = (short)valor;

            bool realmentePodeSacar = saldo > valorSaque && saldo > 0;

            if (realmentePodeSacar)
            {

                MessageBox.Show("o saque foi" + saldo);
            }
            else
            {
                MessageBox.Show("saque impossibilitado");
            }

            MessageBox.Show(message + valorPequeno + nome);
        }

        private void button2_Click(object sender, EventArgs e)
        {//exercicio caputlo 2
            int media;
            media = (idade1 + idade2 + idade3) / 3;
            MessageBox.Show("media" + media);//MessageBox precisa ter ao menos uma parte como string como parametro
        }

        private void button3_Click(object sender, EventArgs e)
        {//exercicio capitulo 3
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("pi qubrado" + piQuebrado);
        }

        private void button4_Click(object sender, EventArgs e)
        {//exerciocio capitulo 3
            double a;
            double b;
            double c;
            double delta;
            double x1;
            double x2;

            a = 5;
            b = -75;
            c = 250;

            delta = b * b - 4 * a * c;
            x1 = Math.Sqrt(delta);
            x1 = ((-b) - x1) / (2 * a);
            x2 = Math.Sqrt(delta);
            x2 = ((-b) + x2) / (2 * a);
            MessageBox.Show("a" + a + " b " + b + " c " + c + "  raiz 1 " + x1 + "raiz 2 " + x2);




        }

        private void button5_Click(object sender, EventArgs e)
        {//ecercicio capitulo 4
            int idade;
            bool brasileira;
            idade = 15;
            brasileira = idade > 16;
            if (brasileira)
            {
                MessageBox.Show("pode votar");
            }
            else
            {
                MessageBox.Show("nao pode votar");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {///exercicio capitulo 4
            double valorDaNotaFiscal;
            double imposto;
            valorDaNotaFiscal = 1500;
            if (valorDaNotaFiscal < 1000)
            {
                MessageBox.Show("imposto = 2");
            }
            else if (valorDaNotaFiscal > 999 && valorDaNotaFiscal < 3000)
            {
                MessageBox.Show("imposto = 2.5%");
            }
            else if (valorDaNotaFiscal > 2999 && valorDaNotaFiscal < 7000)
            {
                MessageBox.Show("imposto=2.8%");
            }
            else
            {
                MessageBox.Show("imposto = 3%");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {//exercicio capitulo 4
            int valor = 15;
            string mensagem = "";
            mensagem = valor > 10 ? "Maior que dez" : "Menor que dez";
            MessageBox.Show(mensagem);
        }

        private void button8_Click(object sender, EventArgs e)
        {//cpaitulo 5
            double valorInvestido = 1000;
            for (int i = 1; i <= 12; i++)
            {
                valorInvestido *= 1.01;
            }
            MessageBox.Show("Valor investido agora é " + valorInvestido);

            double valorInvestido2 = 2000;
            int j = 1;
            while (j <= 12)
            {
                valorInvestido2 *= 1.01;
                j++;
            }
            MessageBox.Show("valor de 2000 em doze meses é" + valorInvestido2);

            double valorInvestido3 = 3000;
            int k = 12;
            do
            {
                valorInvestido3 *= 1.01;
                k++;
            } while (k <= 12);
            MessageBox.Show("valor investido é " + valorInvestido3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //capitulo 5, soma dos numeros de 1 ate 1000
            int soma = 0;
            for (int i = 0; i < 1001; i++)
            {
                soma += i;
            }
            MessageBox.Show("soma de 1 ate 1000 " + soma);
        }

        private void button10_Click(object sender, EventArgs e)
        {//capitulo 5
            for (int i = 3; i < 301; i++)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show("multipli de 3: " + i);

                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {//capitulo5
            int soma = 3;
            for (int i = 3; i < 101; i++)
            {
                if (i % 3 != 0)
                {
                    soma += i;

                }
            }
            MessageBox.Show("a soma dos numeros - multipli de 3: " + soma);
        }

        private void button12_Click(object sender, EventArgs e)
        {//cpitulo 5
            for (int i = 3; i < 31; i++)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show("multipli de 3: " + i);

                }
                else if (i % 4 == 0)
                {
                    MessageBox.Show("multipli de 4: " + i);

                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {//capitulo 5
            int n = 1;

            for (int i = 1; i < 11; i++)
            {
                n *= i;
            }
            MessageBox.Show("fatorial de 10 eh:" + n);
        }

        private void button14_Click(object sender, EventArgs e)
        {//capitulo 5////////////////8=5+3;
            int termoAnterior = 2;
            int termoAnterior2 = 1;

            MessageBox.Show("fibonacci seuqencia: " + 0);
            MessageBox.Show("fibonacci seuqencia: " + 1);
            MessageBox.Show("fibonacci seuqencia: " + 1);
            MessageBox.Show("fibonacci seuqencia: " + 2);
            for (int fibonacci = 2; fibonacci < 88; termoAnterior = fibonacci)
            {
                fibonacci = termoAnterior + termoAnterior2;
                termoAnterior2 = termoAnterior;
                MessageBox.Show("fibonacci seuqencia: " + fibonacci);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {//capitulo 5 - tbela
            string tabela = "1\n";
            int x;

            x = 5;//numero de linhas tabela

            //int n;
            int o;
            // n = x * x;
            for (int i = 2; i < x; i++)
            {
                o = i * i;
                for (int j = 1; j <= o; j++)
                {
                    if (j % i == 0)
                    {
                        tabela += $" {j}";

                    }
                }
                tabela += "\n";
            }
            MessageBox.Show("resposta:\n" + tabela);


        }

        private void button16_Click(object sender, EventArgs e)
        {//capitulo 6
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "rodrigo";
            c.Deposita(100);
            bool deuCerto = c.Saca(1000);

            MessageBox.Show("" + c.saldo);
            if (deuCerto)
            {
                MessageBox.Show("saq ok");
            }
            MessageBox.Show("saldo insuficiente");

            Conta d = new Conta();
            d.numero = 2;
            d.titular = "luiz";
            c.Transfere(1, d);



        }

        private void button17_Click(object sender, EventArgs e)
        {//capitulo 7
            Conta2 g = new Conta2();
            g.Numero = 1;
            MessageBox.Show("numero: " + g.Numero);
            //this.g.Saldo = 100;
            MessageBox.Show("saldo: " + g.Saldo);
            Conta2 fb = new Conta2();
            Cliente cliente = new Cliente();
            fb.Titular = cliente;
            fb.Titular.nome = "a";
            MessageBox.Show("" + fb.Titular.nome);
        }
    }








            //o que faz propriedade
            //Conta2 conta = new Conta2();
            //MessageBox.Show("saldo: " + conta.PegaSaldo());
            // conta.ColocaNumero(1100);

        
        /*{//capitulo 6,7
            bool x;
            bool y;
            Conta2 fb = new Conta2();
            Cliente cliente = new Cliente();

            fb.titular = cliente;
            fb.titular.nome = "fabio";
            fb.numero = 3;
            //fb.saldo = 100;
            fb.idade = 10;
            fb.titular.idade2 = 10;
            MessageBox.Show("" + fb.titular.nome);
            x=fb.Saca(1000);
            if (x)
            {
                MessageBox.Show("acima de idade: ok");
            }
            else { MessageBox.Show("pouca de idade"); 
            }
            y = fb.titular.EhMaiorDeIdade();
            if (y)
            {
                MessageBox.Show("acima de idade: ok");
            }
            else
            {
                MessageBox.Show("pouca de idade");
            }
        }
    }*/
    class Conta
    {//capitulo 6
        public int numero;
        public string titular;
        public double saldo =100;

        public void Transfere (double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
                MessageBox.Show("foi depositado");
            }
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        public bool Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }
    }
}

