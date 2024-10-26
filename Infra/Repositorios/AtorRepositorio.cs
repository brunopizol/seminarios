﻿using moviedb.Domain.Entidades;

namespace moviedb.Infra.Repositorios
{
    public class AtorRepositorio
    {
        public List<Ator> Atores { get; set; }
        public DbContexto DbContexto { get; set; }
        public AtorRepositorio(DbContexto dbContexto)
        {
            this.Atores = new List<Ator>();
            DbContexto = dbContexto;
        }
        public void Criar(Ator ator)
        {
            this.Atores.Add(ator);
            this.DbContexto.Atores.Add(ator);
            this.DbContexto.SaveChanges();
        }

        public List<Ator> BuscarTodosAtores()
        {
            return this.Atores;
        }

        public Ator BuscarAtorPorNome(string nome)
        {
            return this.Atores.Find(x => x.Nome == nome);
        }

        public void AtualizarAtor(Ator ator)
        {
            var AtorResult = this.Atores.Find(x => x.Nome == ator.Nome);
            if (AtorResult != null)
            {
                AtorResult = ator;
            }

        }

        public void DeletarFilme(Ator ator)
        {
            this.Atores.Remove(ator);
        }
    }
}
