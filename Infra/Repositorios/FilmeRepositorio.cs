using moviedb.Domain.Entidades;

namespace moviedb.Infra.Repositorios
{
    public class FilmeRepositorio
    {
        public List<Filme> Filmes { get; set; }
        public DbContexto DbContexto { get; set; }
        public FilmeRepositorio(DbContexto dbContexto)
        {
            DbContexto = dbContexto;
            this.Filmes = new List<Filme>();
        }
        public void Criar(Filme filme)
        {
            this.Filmes.Add(filme);
            this.DbContexto.Filmes.Add(filme);
            this.DbContexto.SaveChanges();
        }

        public List<Filme> BuscarTodosFilmes()
        {
            return this.Filmes;
        }

        public Filme BuscarFilmePorNome(string nome)
        {
              return  this.Filmes.Find(x => x.Nome == nome);
        }

        public void AtualizarFilme(Filme filme)
        {
            var filmeResult = this.Filmes.Find(x => x.Nome == filme.Nome);
            if (filmeResult != null)
            {
                filmeResult = filme;
            }

            }

        public void DeletarFilme(Filme filme)
        {
            this.Filmes.Remove(filme);
        }
    }
}
