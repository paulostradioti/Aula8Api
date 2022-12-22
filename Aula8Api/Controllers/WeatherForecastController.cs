using Aula8Api.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Aula8Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IContadorDeVisitaService _contadorService;

        public WeatherForecastController(IContadorDeVisitaService contadorService)
        {
            _contadorService = contadorService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _contadorService.Incrementar();
            return Ok($"Esta API recebeu {_contadorService.Count} requisições!");
        }
    }
}