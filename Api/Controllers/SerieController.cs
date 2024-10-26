using Microsoft.AspNetCore.Mvc;
using moviedb.Domain.Entidades;
using moviedb.Infra.Repositorios;

namespace moviedb.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SerieController: Controller
    {
        public SerieController(SerieRepositorio serieRepositorio)
        {
            SerieRepositorio = serieRepositorio;
        }

        public SerieRepositorio SerieRepositorio { get; set; } = new SerieRepositorio();

        [HttpGet]
        public ActionResult<IEnumerable<Serie>> BuscarTodasSeries()
        {
            return SerieRepositorio.BuscarTodasSeries();
        }

        [HttpGet("{nome}")]
        public ActionResult<Serie> BuscarSeriePorNome(string nome)
        {
            return SerieRepositorio.BuscarSeriePorNome(nome);
        }

        [HttpPost(Name = "CriarSerie")]
        public void CriarSerie([FromBody] Serie serie)
        {
            SerieRepositorio.Criar(serie);
        }

    }
}
