using RpgMvc.Models.Enuns;

namespace RpgMvc.Models
{
    public class PersonagemViewModel
    {
        public PersonagemViewModel(int id, string nome, int pontosVida, int forca, int defesa, int inteligencia, ClasseEnum classe, int disputas, int vitorias, int derrotas)
        {
            this.Id = id;
            this.Nome = nome;
            this.PontosVida = pontosVida;
            this.Forca = forca;
            this.Defesa = defesa;
            this.Inteligencia = inteligencia;
            this.Classe = classe;
            this.Disputas = disputas;
            this.Vitorias = vitorias;
            this.Derrotas = derrotas;

        }
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }
        public ClasseEnum Classe { get; set; }
        public byte[]? FotoPersonagem { get; set; }

       // public List<PersonagemHabilidade>? PersonagemHabilidades { get; set; }

        public int Disputas { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
    }
}