using RpgMvc.Models.Enuns;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace RpgMvc.Models
{
    public class PersonagemViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }
        public int Disputas { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }

        public ClassEnum Classe { get; set; }

        public byte[] FotoPersonagem { get; set;}

        //public Usuario Usuario { get; set;}

        //public Arma Arma { get; set;}

        public List<PersonagemHabilidadeViewModel> PersonagemHabilidades { get; set;}
    }
}