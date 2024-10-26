using Microsoft.AspNetCore.Mvc;
using moviedb.Domain.Entidades;
using moviedb.Infra.Repositorios;

namespace moviedb.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        public FilmeRepositorio filmeRepositorio { get; set; }  
   
        public FilmeController(FilmeRepositorio repositorio)
        {
            filmeRepositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Filme>> BuscarTodosFilmes()
        {
            return filmeRepositorio.BuscarTodosFilmes();
        }

        [HttpGet("{nome}")]
        public ActionResult<Filme> BuscarFilmePorNome(string nome)
        {
            return filmeRepositorio.BuscarFilmePorNome(nome);
        }

        [HttpPost(Name = "CriarFilme")]
        public void CriarFilme([FromBody] Filme filme)
        {
            filmeRepositorio.Criar(filme);
        }
    }
}
