using PROVA.Enumerators;

namespace PROVA.Domain
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;

        public EnumGenero Genero { get; set; }

        public string Diretor { get; set; } = string.Empty;

        public int AnoLancamento { get; set; }

        public string Sispnose { get; set;} 

        public int Duracao { get; set; }


    }
}
