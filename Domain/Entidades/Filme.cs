using moviedb.Domain.Enumeradores;

namespace moviedb.Domain.Entidades
{
    public class Filme
    {
        public int Id { get; set; } 
        public int DiretorId { get; set; } 
        public string Nome { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }
        public Genero Genero { get; set; }


    }
}
