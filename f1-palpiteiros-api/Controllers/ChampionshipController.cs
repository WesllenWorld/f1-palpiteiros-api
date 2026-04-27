using F1Palpiteiros.DTOs;
using F1Palpiteiros.Services;
using Microsoft.AspNetCore.Mvc;

namespace F1Palpiteiros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChampionshipController : ControllerBase
    {
        
        private readonly IChampionshipService _championshipService;

        public ChampionshipController(IChampionshipService championshipService)
        {
            _championshipService = championshipService;
        }

        /*
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
        }*/

        //criar um novo campeonato
        //IMPLEMENTAR validação de dados
        [HttpPost]
        public async Task<IActionResult> CreateChampionship([FromBody] CreateChampionshipDTO createChampionshipDTO)
        {

            try
            {
                var result = await _championshipService.CreateChampionship(createChampionshipDTO);
                return Ok(result);
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
