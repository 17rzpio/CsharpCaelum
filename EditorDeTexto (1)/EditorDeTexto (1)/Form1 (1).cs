using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MinhasExtensoes2;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Stream entrada = File.Open("text.txt", FileMode.Open))
            using (StreamReader leitor = new StreamReader(entrada))
            {
                string textoTotal = leitor.ReadToEnd();
                textoConteudo.Text += textoTotal;
            }
        }

        private void botaoGrava_Click(object sender, EventArgs e)
        {
            using (Stream saida = File.Open("text.txt", FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))
            {
                escritor.Write(textoConteudo.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            string busca = textoBusca.Text;
            string textoDoEditor = textoConteudo.Text;
            int resultado = textoDoEditor.IndexOf(busca);
            if (resultado >= 0)
            {
                MessageBox.Show("achei o texto " + busca);
            }
            else
            {
                MessageBox.Show("não achei");
            }
        }

        private void botaoReplace_Click(object sender, EventArgs e)
        {
            string busca = textoBusca.Text;
            string replace = textoReplace.Text;
            string textoDoEditor = textoConteudo.Text;
            textoDoEditor = textoDoEditor.Replace(busca, replace);
            textoConteudo.Text = textoDoEditor;
        }

        private void botaoToUpper_Click(object sender, EventArgs e)
        {
            int inicioSelecao = textoConteudo.SelectionStart;
            int tamanhoSelecao = textoConteudo.SelectionLength;

            //substring pega o texto selecionado
            string textoSelecionado = textoConteudo.Text.Substring(inicioSelecao, tamanhoSelecao);

            //pega texto antes da selecao que é necessário
            string antes = textoConteudo.Text.Substring(0, inicioSelecao);

            //pegar texto depois da seleção que é necessário
            string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao);

            //efetivar redefinindo o campo texto 
            textoConteudo.Text = antes + textoSelecionado.ToUpper() + depois;
        }

        private void botaoToLower_Click(object sender, EventArgs e)
        {
            int inicioSelecao = textoConteudo.SelectionStart;
            int tamanhoSelecao = textoConteudo.SelectionLength;

            //substring pega o texto selecionado
            string textoSelecionado = textoConteudo.Text.Substring(inicioSelecao, tamanhoSelecao);

            //pega texto antes da selecao que é necessário
            string antes = textoConteudo.Text.Substring(0, inicioSelecao);

            //pegar texto depois da seleção que é necessário
            string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao);

            //efetivar redefinindo o campo texto 
            textoConteudo.Text = antes + textoSelecionado.ToLower() + depois;
        }

        private void botaoPlural_Click(object sender, EventArgs e)
        {
            int inicioSelecao = textoConteudo.SelectionStart;
            int tamanhoSelecao = textoConteudo.SelectionLength;

            //substring pega o texto selecionado
            string textoSelecionado = textoConteudo.Text.Substring(inicioSelecao, tamanhoSelecao);

            //pega texto antes da selecao que é necessário
            string antes = textoConteudo.Text.Substring(0, inicioSelecao);

            //pegar texto depois da seleção que é necessário
            string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao);



            string plural;
            plural = textoSelecionado.Pluralize();

            //efetivar redefinindo o campo texto 
            textoConteudo.Text = antes + plural + depois;
        }
    }
    
}
//---------------
//apendice
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.IO;

//namespace EditorDeTexto
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            using (Stream entrada = File.Open("text.txt", FileMode.Open))
//            using (StreamReader leitor = new StreamReader(entrada))
//            {
//                string textoTotal = leitor.ReadToEnd();
//                textoConteudo.Text += textoTotal;
//            }
//        }

//        private void botaoGrava_Click(object sender, EventArgs e)
//        {
//            using (Stream saida = File.Open("text.txt", FileMode.Create))
//            using (StreamWriter escritor = new StreamWriter(saida))
//            {
//                escritor.Write(textoConteudo.Text);
//            }
//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void botaoBusca_Click(object sender, EventArgs e)
//        {
//            string busca = textoBusca.Text;
//            string textoDoEditor = textoConteudo.Text;
//            int resultado = textoDoEditor.IndexOf(busca);
//            if (resultado >= 0)
//            {
//                MessageBox.Show("achei o texto " + busca);
//            }
//            else
//            {
//                MessageBox.Show("não achei");
//            }
//        }

//        private void botaoReplace_Click(object sender, EventArgs e)
//        {
//            string busca = textoBusca.Text;
//            string replace = textoReplace.Text;
//            string textoDoEditor = textoConteudo.Text;
//            textoDoEditor = textoDoEditor.Replace(busca, replace);
//            textoConteudo.Text = textoDoEditor;
//        }

//        private void botaoToUpper_Click(object sender, EventArgs e)
//        {
//            int inicioSelecao = textoConteudo.SelectionStart;
//            int tamanhoSelecao = textoConteudo.SelectionLength;

//            //substring pega o texto selecionado
//            string textoSelecionado = textoConteudo.Text.Substring(inicioSelecao, tamanhoSelecao);

//            //pega texto antes da selecao que é necessário
//            string antes = textoConteudo.Text.Substring(0, inicioSelecao);

//            //pegar texto depois da seleção que é necessário
//            string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao);

//            //efetivar redefinindo o campo texto 
//            textoConteudo.Text = antes + textoSelecionado.ToUpper() + depois;
//        }

//        private void botaoToLower_Click(object sender, EventArgs e)
//        {
//            int inicioSelecao = textoConteudo.SelectionStart;
//            int tamanhoSelecao = textoConteudo.SelectionLength;

//            //substring pega o texto selecionado
//            string textoSelecionado = textoConteudo.Text.Substring(inicioSelecao, tamanhoSelecao);

//            //pega texto antes da selecao que é necessário
//            string antes = textoConteudo.Text.Substring(0, inicioSelecao);

//            //pegar texto depois da seleção que é necessário
//            string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao);

//            //efetivar redefinindo o campo texto 
//            textoConteudo.Text = antes + textoSelecionado.ToLower() + depois;
//        }

//        private void botaoPlural_Click(object sender, EventArgs e)
//        {
//            int inicioSelecao = textoConteudo.SelectionStart;
//            int tamanhoSelecao = textoConteudo.SelectionLength;

//            //substring pega o texto selecionado
//            string textoSelecionado = textoConteudo.Text.Substring(inicioSelecao, tamanhoSelecao);

//            //pega texto antes da selecao que é necessário
//            string antes = textoConteudo.Text.Substring(0, inicioSelecao);

//            //pegar texto depois da seleção que é necessário
//            string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao);

//            string plural;
//            plural = StringUtil.Pluralize(textoSelecionado);

//            //efetivar redefinindo o campo texto 
//            textoConteudo.Text = antes + plural + depois;
//        }
//    }
//    public static class StringUtil
//    {
//        public static string Pluralize (string texto)
//        {
//            if (texto.EndsWith("s"))
//            {
//                return texto;
//            }
//            else
//            {
//                return texto + "s";
//            }
//        }
//    }
//}
//------------------------------------------------------------------------------------------------------------------
//Capitulo 23 exercícios 1,2,3,4,5
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.IO;

//namespace EditorDeTexto
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            using (Stream entrada = File.Open("text.txt", FileMode.Open))
//            using(StreamReader leitor = new StreamReader(entrada))
//            {
//                string textoTotal = leitor.ReadToEnd();
//                textoConteudo.Text += textoTotal;
//            }
//        }

//        private void botaoGrava_Click(object sender, EventArgs e)
//        {
//            using (Stream saida = File.Open("text.txt", FileMode.Create))
//            using (StreamWriter escritor = new StreamWriter(saida))
//            {
//                escritor.Write(textoConteudo.Text);
//            }
//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void botaoBusca_Click(object sender, EventArgs e)
//        {
//            string busca = textoBusca.Text;
//            string textoDoEditor = textoConteudo.Text;
//            int resultado = textoDoEditor.IndexOf(busca);
//            if (resultado >= 0)
//            {
//                MessageBox.Show("achei o texto "+ busca);
//            }
//            else
//            {
//                MessageBox.Show("não achei");
//            }
//        }

//        private void botaoReplace_Click(object sender, EventArgs e)
//        {
//            string busca = textoBusca.Text;
//            string replace = textoReplace.Text;
//            string textoDoEditor = textoConteudo.Text;
//            textoDoEditor = textoDoEditor.Replace(busca,replace);
//            textoConteudo.Text = textoDoEditor;
//        }

//        private void botaoToUpper_Click(object sender, EventArgs e)
//        {
//            string textoDoEditor = textoConteudo.Text;
//            textoDoEditor = textoDoEditor.ToUpper();
//            textoConteudo.Text = textoDoEditor;
//        }

//        private void botaoToLower_Click(object sender, EventArgs e)
//        {
//            string textoDoEditor = textoConteudo.Text;
//            textoDoEditor = textoDoEditor.ToLower();
//            textoConteudo.Text = textoDoEditor;

//        }
//    }
//}
//----------------------------------------------------------------------------------------------------------------
//capitulo 22 exercicio 4
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.IO;

//namespace EditorDeTexto
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            if (File.Exists("text.txt"))
//            {
//                Stream arquivo = null;
//                StreamReader leitor = null;
//                try
//                {
//                    arquivo = File.Open("text.txt", FileMode.Open);
//                    leitor = new StreamReader(arquivo);
//                    string textoTotal = leitor.ReadToEnd();

//                    textoConteudo.Text += textoTotal;
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("erro!");
//                }
//                finally
//                {
//                    if (leitor != null)
//                    {
//                        leitor.Close();

//                    }
//                    if (arquivo != null)
//                    {
//                        arquivo.Close();
//                    }
//                }






//            }
//        }

//        private void botaoGrava_Click(object sender, EventArgs e)
//        {
//            Stream arquivo = null;
//            StreamWriter escritor = null;
//            try
//            {
//                arquivo = File.Open("text.txt", FileMode.Open);
//                escritor = new StreamWriter(arquivo);
//                escritor.Write(textoConteudo.Text);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("erro!");
//            }
//            finally
//            {
//                if (escritor != null)
//                {
//                    escritor.Close();

//                }
//                if (arquivo != null)
//                {
//                    arquivo.Close();
//                }
//            }
//        }
//    }
//}
//-----------------------------------------------------------------------------------------------------
//capitulo 22 exercício 3
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.IO;

//namespace EditorDeTexto
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            if (File.Exists("text.txt"))
//            {
//                Stream entrada = File.Open("text.txt", FileMode.Open);
//                StreamReader leitor = new StreamReader(entrada);
//                string textoTotal = leitor.ReadToEnd();


//                textoConteudo.Text += textoTotal;

//                leitor.Close();
//                entrada.Close();

//            }
//        }

//        private void botaoGrava_Click(object sender, EventArgs e)
//        {
//            Stream saida = File.Open("C:text.txt", FileMode.Create);
//            StreamWriter escritor = new StreamWriter(saida);
//            escritor.Write(textoConteudo.Text);
//            escritor.Close();
//            saida.Close();
//        }
//    }
//}
//-----------------------------------------------------------------------------------------------------
//Capitulo 22 exercicio 1 e 2

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.IO;

//namespace EditorDeTexto
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            if (File.Exists("text.txt"))
//            {
//                Stream entrada = File.Open("text.txt", FileMode.Open);
//                StreamReader leitor = new StreamReader(entrada);
//                string linha = leitor.ReadLine();
//                while(linha!=null)
//                {
//                    textoConteudo.Text += linha;
//                    linha = leitor.ReadLine();
//                }
//                leitor.Close();
//                entrada.Close();

//            }
//        }

//        private void botaoGrava_Click(object sender, EventArgs e)
//        {
//            Stream saida = File.Open("C:text.txt", FileMode.Create);
//            StreamWriter escritor = new StreamWriter(saida);
//            escritor.Write(textoConteudo.Text);
//            escritor.Close();
//            saida.Close();
//        }
//    }
//}
