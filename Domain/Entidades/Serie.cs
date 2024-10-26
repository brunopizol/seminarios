namespace moviedb.Domain.Entidades
{
    public class Serie: Filme
    {
        public int NumeroDeTemporadas {  get; set; }
        public bool EmProducao { get; set; }
        public int NumeroDeEpisodios { get; set; }
    }
}
