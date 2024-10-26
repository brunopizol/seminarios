using moviedb.Domain.Entidades;

namespace moviedb.Infra.Repositorios
{
    public class SerieRepositorio
    {
        public List<Serie> Series { get; set; }
        public DbContexto DbContexto { get; set; }
        public SerieRepositorio(DbContexto dbContexto)
        {
            this.Series = new List<Serie>();
            DbContexto = dbContexto;
        }
        public void Criar(Serie serie)
        {
            this.Series.Add(serie);
            this.DbContexto.Series.Add(serie);
            this.DbContexto.SaveChanges();
        }

        public List<Serie> BuscarTodasSeries()
        {
            return this.Series;
        }

        public Serie BuscarSeriePorNome(string nome)
        {
            return this.Series.Find(x => x.Nome == nome);
        }

        public void AtualizarSerie(Serie serie)
        {
            var SerieResult = this.Series.Find(x => x.Nome == serie.Nome);
            if (SerieResult != null)
            {
                SerieResult = serie;
            }

        }

        public void DeletarSerie(Serie serie)
        {
            this.Series.Remove(serie);
        }
    }
}
