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
using System.Runtime;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Conta> dicionario;
        private List<Conta> contas;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new List<Conta>();
            this.dicionario = new Dictionary<string, Conta>();
            
        }
        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;


              Conta selecionada = (Conta)comboContas.SelectedItem;


            //Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textValor.Text);

            try
            {
                selecionada.Deposita(valor);

                textSaldo.Text = Convert.ToString(selecionada.Saldo);
               
                MessageBox.Show("Dinheiro depositado");

            }
            
            catch (ArgumentException ex)
            {
                MessageBox.Show("Não é possível depositar um valor negativo");
            }
            //selecionada.Deposita(valor);
            //textSaldo.Text = Convert.ToString(selecionada.Saldo);
        }
        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;

            //Object itemSelecionado = comboContas.SelectedItem;
            //string teste = itemSelecionado.ToString();

            Conta selecionada = (Conta)comboContas.SelectedItem;
            //    Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textValor.Text);

            

            try
            {
                selecionada.Saca(valor);
               
                textSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Dinheiro liberado");

            }catch(SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo insuficiente");
            }catch(ArgumentException ex)
            {
                MessageBox.Show("Não é possível sacar um valor negativo");
            }
        }        
        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = (Conta)comboContas.SelectedItem;
            //  Conta selecionada = this.contas[indice];

            textTitular.Text = selecionada.Titular.Nome;
            textSaldo.Text = Convert.ToString(selecionada.Saldo);
            textNumero.Text = Convert.ToString(selecionada.Numero);
        }

        private void botaoTransferencia_Click(object sender, EventArgs e)
        {
            //int indice = comboContas.SelectedIndex;
            //int indice2 = comboDestinoTransferencia.SelectedIndex;

            //Conta selecionada = this.contas[indice];
            //Conta selecionada2 = this.contas[indice2];

            //double valor = Convert.ToDouble(textValor.Text);
            //selecionada2.Deposita(valor);
            //textSaldo.Text = Convert.ToString(selecionada2.Saldo);
        }
        private void butaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadasroConta formularioCadastro = new FormCadasroConta(this);
            formularioCadastro.ShowDialog();
        }
        public void AdicionaConta(Conta conta)
        {
            contas.Add(conta);
            comboContas.Items.Add(conta);
            this.dicionario.Add(conta.Titular.Nome, conta);
            //capitulo 20 com listas
            //this.contas.Add(conta);
            //comboContas.Items.Add(conta);
            //comboContas.DisplayMember = "Numero";//capitulo 18
        }
        private void textTitular_TextChanged(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void butaoTeste_Click(object sender, EventArgs e)
        {//apitulo 20
         //string titularDaBusca = "rodrigo";
         //Conta resultado = null;
         //foreach (Conta conta in contas)
         //{
         //    if (conta.Titular.Nome.Equals(titularDaBusca))
         //    {
         //        resultado = conta;
         //        MessageBox.Show("" + resultado);
         //        break;
         //    }
         //}

            ////}
            ////teste apendice
            //Conta c = new ContaCorrente();
            //Cliente titular = new Cliente("rodrigo");
            //ContaExtensions.MudaTitular(c, titular);
            //MessageBox.Show(c.Titular.Nome);
        }
        private void botaoPoupanca_Click(object sender, EventArgs e)
        {
        }
        private void botaoBuscar_Click(object sender, EventArgs e)
        {
        }

        private void botaoImposto_Click(object sender, EventArgs e)
        {
            //ContaCorrente conta = new ContaCorrente();
            //conta.Deposita(200);
            //MessageBox.Show("imposto da conta corrente = " + conta.CalcularTributo());
            //ITributavel t = conta;
            //MessageBox.Show("imposto da conta pela interface "+t.CalcularTributo());

            //SeguroDeVida sv = new SeguroDeVida();
            //MessageBox.Show("impsto do seguro= "+sv.CalcularTributo());

            //t = sv;
            //MessageBox.Show("impsto do seguro pela interface" + t.CalcularTributo());

            //TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            //totalizador.Adicional(conta);
            //MessageBox.Show("Total: "+totalizador.Total);
            //totalizador.Adicional(sv);
            //MessageBox.Show("Total: "+totalizador.Total);

            //ContaCorrente conta2 = new ContaCorrente();
            //foreach(Conta contas2 in contas)
            //{
            //    if (contas2 is ContaCorrente conta3)
            //    {
            //        totalizador.Adicional(conta3);
            //    }

            //}

            //MessageBox.Show("Total: " + totalizador.Total);
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            int x = 0;
            foreach (KeyValuePair<string, Conta> par in dicionario)
            {
                
                string chave = par.Key;
                if (chave == textoBuscaTitular.Text)
                {
                     x = 1;
                    string nomeTitular = textoBuscaTitular.Text;
                    Conta conta = dicionario[nomeTitular];
                    comboContas.SelectedItem = conta;
                    textoBuscaTitular.Text = conta.Titular.Nome;
                    textTitular.Text = Convert.ToString(conta.Titular.Nome);
                    textNumero.Text = Convert.ToString(conta.Numero);
                    textSaldo.Text = Convert.ToString(conta.Saldo);
                }

            }
            if (x == 0)
            {
                MessageBox.Show("nao ha cadastro");
            }

        }

        private void botaoRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios(this.contas);
            form.ShowDialog();
        }
        public void Relatorio()
        {


        }
        //public static void MudaSaldo(this Conta conta, double novoSaldo)//teste apendice
        //{
        //    novoSaldo = 4;
        //    conta.Saldo = novoSaldo;
        //}
        //------------------------------------------------------
        //public static class ContaExtensions//teste apendice
        //{
        //    public static void MudaTitular(this Conta conta, Cliente titular)
        //    {
        //        conta.Titular = titular;
        //    }
        //}
        
    }
}
//int proxima = ContaCorrente.ProximaConta();

//capitulo 18
//public partial class Form1 : Form
//{
//    private Conta conta;
//    private Conta[] contas;
//    private int numeroDeContas = 0;
//    public Form1()
//    {
//        InitializeComponent();
//    }
//    private void Form1_Load(object sender, EventArgs e)
//    {
//        this.contas = new Conta[1];

//        this.contas[0] = new ContaCorrente();
//        this.contas[0].Titular = new Cliente("a");
//        this.contas[0].Numero = 1;
//        (this.numeroDeContas)++;
//        //comboContas.Items.Add("titular: " + contas[0]);
//        comboContas.Items.Add("" + this.contas[0].Titular.Nome);

//        ContaCorrente c2 = new ContaCorrente();
//        c2.Titular = new Cliente("ba");
//        c2.Numero = 2;
//        this.AdicionaConta(c2);

//        ContaCorrente c3 = new ContaCorrente();
//        c3.Titular = new Cliente("32a");
//        c3.Numero = 3;
//        this.AdicionaConta(c3);
//    }
//    private void botaoDeposito_Click(object sender, EventArgs e)
//    {
//        int indice = comboContas.SelectedIndex;


//        //   Conta selecionada = (Conta)comboContas.SelectedItem;


//        Conta selecionada = this.contas[indice];

//        double valor = Convert.ToDouble(textValor.Text);

//        try
//        {
//            selecionada.Deposita(valor);

//            textSaldo.Text = Convert.ToString(selecionada.Saldo);

//            MessageBox.Show("Dinheiro depositado");

//        }

//        catch (ArgumentException ex)
//        {
//            MessageBox.Show("Não é possível depositar um valor negativo");
//        }
//        //selecionada.Deposita(valor);
//        //textSaldo.Text = Convert.ToString(selecionada.Saldo);
//    }
//    private void botaoSaque_Click(object sender, EventArgs e)
//    {
//        int indice = comboContas.SelectedIndex;

//        //Object itemSelecionado = comboContas.SelectedItem;
//        //string teste = itemSelecionado.ToString();


//        Conta selecionada = this.contas[indice];

//        double valor = Convert.ToDouble(textValor.Text);



//        try
//        {
//            selecionada.Saca(valor);

//            textSaldo.Text = Convert.ToString(selecionada.Saldo);
//            MessageBox.Show("Dinheiro liberado");

//        }
//        catch (SaldoInsuficienteException ex)
//        {
//            MessageBox.Show("Saldo insuficiente");
//        }
//        catch (ArgumentException ex)
//        {
//            MessageBox.Show("Não é possível sacar um valor negativo");
//        }
//    }
//    private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
//    {
//        int indice = comboContas.SelectedIndex;

//        Conta selecionada = this.contas[indice];

//        textTitular.Text = selecionada.Titular.Nome;
//        textSaldo.Text = Convert.ToString(selecionada.Saldo);
//        textNumero.Text = Convert.ToString(selecionada.Numero);
//    }

//    private void botaoTransferencia_Click(object sender, EventArgs e)
//    {
//        int indice = comboContas.SelectedIndex;
//        int indice2 = comboDestinoTransferencia.SelectedIndex;

//        Conta selecionada = this.contas[indice];
//        Conta selecionada2 = this.contas[indice2];

//        double valor = Convert.ToDouble(textValor.Text);
//        selecionada2.Deposita(valor);
//        textSaldo.Text = Convert.ToString(selecionada2.Saldo);
//    }
//    private void butaoNovaConta_Click(object sender, EventArgs e)
//    {
//        FormCadasroConta formularioCadastro = new FormCadasroConta(this);
//        formularioCadastro.ShowDialog();
//    }
//    public void AdicionaConta(Conta conta)
//    {
//        var usageList = contas.ToList();
//        usageList.Add(conta);
//        contas = usageList.ToArray();


//        //contas.Append(conta).ToArray();
//        //this.contas[this.numeroDeContas] = conta;
//        (this.numeroDeContas)++;



//        comboContas.Items.Add(conta.Titular.Nome.ToString());
//        comboContas.DisplayMember = "Numero";
//        //comboContas.Items.Add("titular: " + conta);


//    }
//    private void textTitular_TextChanged(object sender, EventArgs e)
//    {
//    }
//    private void label3_Click(object sender, EventArgs e)
//    {
//    }
//    private void butaoTeste_Click(object sender, EventArgs e)
//    {
//        if (contas[0].Equals(contas[1]))
//        {
//            MessageBox.Show("iguais");
//        }
//        else
//        {
//            MessageBox.Show("diferentes");
//        }
//    }
//    private void botaoPoupanca_Click(object sender, EventArgs e)
//    {
//    }
//    private void botaoBuscar_Click(object sender, EventArgs e)
//    {
//    }

//    private void botaoImposto_Click(object sender, EventArgs e)
//    {
//        ContaCorrente conta = new ContaCorrente();
//        conta.Deposita(200);
//        MessageBox.Show("imposto da conta corrente = " + conta.CalcularTributo());
//        ITributavel t = conta;
//        MessageBox.Show("imposto da conta pela interface " + t.CalcularTributo());

//        SeguroDeVida sv = new SeguroDeVida();
//        MessageBox.Show("impsto do seguro= " + sv.CalcularTributo());

//        t = sv;
//        MessageBox.Show("impsto do seguro pela interface" + t.CalcularTributo());

//        TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
//        totalizador.Adicional(conta);
//        MessageBox.Show("Total: " + totalizador.Total);
//        totalizador.Adicional(sv);
//        MessageBox.Show("Total: " + totalizador.Total);

//        ContaCorrente conta2 = new ContaCorrente();
//        foreach (Conta contas2 in contas)
//        {
//            if (contas2 is ContaCorrente conta3)
//            {
//                totalizador.Adicional(conta3);
//            }

//        }

//        MessageBox.Show("Total: " + totalizador.Total);
//    }
//}





/*até o capitulo 12
public partial class Form1 : Form
{
    private Conta conta;
    private ContaPoupanca conta2;

    private TotalizadorDeContas conta3;

    private Conta[] contas2;

    private Conta[] contas3;
    private int numeroDeContas=0;


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
        Conta c = new Conta(2);
        c.Numero = 1;
        Cliente cliente = new Cliente("rodrigo Pioner");
        c.Titular = cliente;

        textTitular.Text = c.Titular.Nome; 
        textNumero.Text = Convert.ToString(c.Numero);
        textSaldo.Text = Convert.ToString(c.Saldo);

       this.conta = new Conta(2);
        //this.conta = new ContaPoupanca();
        //this.conta = new ContaCorrente();


        contas2 = new Conta[3];

        this.contas2[0] = new Conta(2);
        this.contas2[0].Titular = new Cliente("eu");
        this.contas2[0].Numero = 1;

        this.contas2[1] = new ContaPoupanca(9);
        this.contas2[1].Titular = new Cliente("voce");
        this.contas2[1].Numero = 4;

        this.contas2[2] = new ContaCorrente(8);
        this.contas2[2].Titular = new Cliente("nós");
        this.contas2[2].Numero = 2;

       // comboContas.Items.Add("Conta bancaria");
          //   comboContas.Items.Add(contas2[0].Titular.Nome);
        //comboContas.Items.Add(contas2[1].Titular.Nome);
        //comboContas.Items.Add(contas2[2].Titular.Nome);



     foreach(Conta conta in contas2)
        {
            comboContas.Items.Add(conta.Titular.Nome);
        }
        foreach(Conta conta in contas2)//cpitulo11
        {
            comboDestinoTransferencia.Items.Add(conta.Titular.Nome);
        }
        //capitulo 12
        this.contas3 = new Conta[10];

        Conta c1 = new Conta(1);
        c1.Titular = new Cliente("a");
        c1.Numero = 2;
        this.AdicionaConta(c1);
        Conta c2 = new Conta(1);
        c2.Titular = new Cliente("2a");
        c2.Numero = 22;
        this.AdicionaConta(c2);
        Conta c3 = new Conta(1);
        c3.Titular = new Cliente("32a");
        c3.Numero = 223;
        this.AdicionaConta(c3);
    }

    private void botaoDeposito_Click(object sender, EventArgs e)
    {//capitulo11


        int indice = comboContas.SelectedIndex;
        Conta selecionada = this.contas2[indice];

        double valor = Convert.ToDouble(textValor.Text);
        selecionada.Deposita(valor);
        textSaldo.Text = Convert.ToString(selecionada.Saldo);



       // capitulo10
        //int indice = Convert.ToInt32(textBuscar.Text);
        //Conta selecionada = this.contas2[indice];

        //double valor = Convert.ToDouble(textValor.Text);
        //selecionada.Deposita(valor);
        //textSaldo.Text = Convert.ToString(selecionada.Saldo);




        //capitulo9
        ///string valorDigitado = textValor.Text;
        //double valorOperacao = Convert.ToDouble(valorDigitado);
       // this.conta.Deposita(valorOperacao);
       // textSaldo.Text = Convert.ToString(this.conta.Saldo);
       // MessageBox.Show("Sucesso!!!");
    }

    private void botaoSaque_Click(object sender, EventArgs e)
    {//capitulo11

        int indice = comboContas.SelectedIndex;
        Conta selecionada = this.contas2[indice];

        double valor = Convert.ToDouble(textValor.Text);
        selecionada.Saca(valor);
        textSaldo.Text = Convert.ToString(selecionada.Saldo);


     //  / capitulo10
      //  int indice = Convert.ToInt32(textBuscar.Text);
       // Conta selecionada = this.contas2[indice];

        //double valor = Convert.ToDouble(textValor.Text);
        //selecionada.Saca(valor);
        //textSaldo.Text = Convert.ToString(selecionada.Saldo);


        //capitulo9
        //string valorDigitado = textValor.Text;
        //double valorOperacao = Convert.ToDouble(valorDigitado);
       // this.conta.Saca(valorOperacao);
       // textSaldo.Text = Convert.ToString(this.conta.Saldo);
       // MessageBox.Show("Sucesso");
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

    private void botaoPoupanca_Click(object sender, EventArgs e)
    {//capitulo 9


        this.conta2 = new ContaPoupanca(3);


        string valorDigitado = textValor.Text;
        double valorOperacao = Convert.ToDouble(valorDigitado);
        this.conta2.Saca(valorOperacao);
        textSaldo.Text = Convert.ToString(this.conta2.Saldo);
        MessageBox.Show("Sucesso");

        this.conta3 = new TotalizadorDeContas();

        this.conta3.Adiciona(this.conta);
        this.conta3.Adiciona(this.conta2);
        MessageBox.Show("Total "+ this.conta3.ValorTotal);


        Conta[] contas = new Conta[3];

        contas[0] = new Conta(1);
        contas[1] = new ContaPoupanca(1);
        contas[2] = new ContaCorrente(1);
        for (int i=0; i<contas.Length; i++)
        {
            string valorDigitado2 = textValor.Text;
            double valorOperacao2 = Convert.ToDouble(valorDigitado2);
            contas[i].Saca(valorOperacao2);
            textSaldo.Text = Convert.ToString(contas[i].Saldo);
            MessageBox.Show("Sucesso");

        }
        foreach(Conta c in contas)
        {
            MessageBox.Show("saldo= " + c.Saldo);
        }


        // ContaPoupanca c5 = new ContaPoupanca();
        c5.Tipo = 1;
        c5.Deposita(100);
        c5.Saca(50);
        MessageBox.Show("Test "+c5.Saldo);

        Conta c1 = new Conta();
        ContaPoupanca c2 = new ContaPoupanca();
        TotalizadorDeContas t = new TotalizadorDeContas();
        c1.Deposita(1000);
        c2.Deposita(5000);
        t.Soma(c1);
        t.Soma(c2);
        MessageBox.Show("Test"+t.ValorTotal);
    }

    private void botaoBuscar_Click(object sender, EventArgs e)
    {//capitulo10
        int indice = Convert.ToInt32(textBuscar.Text);
        Conta selecionada = this.contas2[indice];
        textNumero.Text = Convert.ToString(selecionada.Numero);
        textTitular.Text = selecionada.Titular.Nome;
        textSaldo.Text = Convert.ToString(selecionada.Saldo);
    }

    private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
    {//capitulo10
        int indice = comboContas.SelectedIndex;
        Conta selecionada = this.contas2[indice];
        textTitular.Text = selecionada.Titular.Nome;
        textSaldo.Text = Convert.ToString(selecionada.Saldo);
        textNumero.Text = Convert.ToString(selecionada.Numero);
    }

    private void botaoTransferencia_Click(object sender, EventArgs e)
    {//capitulo11
        int indice = comboContas.SelectedIndex;
        int indice2 = comboDestinoTransferencia.SelectedIndex;

        Conta selecionada = this.contas2[indice];
        Conta selecionada2 = this.contas2[indice2];



        double valor = Convert.ToDouble(textValor.Text);
        selecionada2.Deposita(valor);
        textSaldo.Text = Convert.ToString(selecionada2.Saldo);
    }

    private void butaoNovaConta_Click(object sender, EventArgs e)
    {
        FormCadasroConta formularioCadastro = new FormCadasroConta(this);
        formularioCadastro.ShowDialog();
    }
    public void AdicionaConta(Conta conta4)
    {//capitulo 12
        this.contas3.Append(conta4);
        (this.numeroDeContas)++;
        comboContas.Items.Add("titular: " + conta4.Titular.Nome);
    }
}*/

