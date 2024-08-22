namespace Banco
{
    public class Cliente
    {
        private string v;

        

        public string Nome { get; set; }

        public int Idade { get; set; }
        public string Documentos { get; set; }

        public string CPF { get; set; }
        public Cliente(string nome)
        {
            this.Nome = nome;

        }

        public bool PodeAbrirContaSozinho
        {
            get
            {
                var maiorDeIdade = this.Idade >= 18;
                var emancipado = this.Documentos.Contains("emancipacao");
                var possuiCPF = !string.IsNullOrEmpty(this.CPF);
                return (maiorDeIdade || emancipado) && possuiCPF;
            }
        }
        
    }
}