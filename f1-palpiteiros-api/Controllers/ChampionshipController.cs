using F1Palpiteiros.DTOs;
using F1Palpiteiros.Services;
using Microsoft.AspNetCore.Mvc;

namespace F1Palpiteiros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChampionshipController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IChampionshipService _championshipService;

        public ChampionshipController(ILogger<WeatherForecastController> logger, IChampionshipService championshipService)
        {
            _logger = logger;
            _championshipService = championshipService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //criar um novo campeonato
        //IMPLEMENTAR
        public async Task<IActionResult> CreateChampionship([FromBody] CreateChampionshipDTO createChampionshipDTO)
        {

            try
            {
                return Ok(_championshipService.CreateChampionship(createChampionshipDTO));
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //listar campeonatos
        //IMPLEMENTAR


        //editar campeonato
        //IMPLEMENTAR

        //excluir campeonato
        //IMPLEMENTAR


    }
}
