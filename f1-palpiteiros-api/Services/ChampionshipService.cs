using F1Palpiteiros.DTOs;
using F1Palpiteiros.Model;
using F1Palpiteiros.Repositories;

namespace F1Palpiteiros.Services
{
    public class ChampionshipService : IChampionshipService
    {
        private readonly IChampionshipRepository _championshiprepository;

        public ChampionshipService(IChampionshipRepository championshiprepository)
        {
            _championshiprepository = championshiprepository;
        }
        public async Task<ChampionshipDTO> CreateChampionship(CreateChampionshipDTO createChampionshipDTO)
        { 
            // Lógica para validar nome do campeonato
            if(string.IsNullOrEmpty(createChampionshipDTO.SeasonName))
            {
                throw new ArgumentException("SeasonName is required.");
            }
            if(createChampionshipDTO.SeasonName.Length > 100)
            {
                throw new ArgumentException("SeasonName cannot exceed 100 characters.");
            }

            //validar ano (dentro dos padrões do int)
            //validação

            //válido -> prossegue para acessar database
            Championship championship = await _championshiprepository.AddAsync(new Championship
            {
                SeasonName = createChampionshipDTO.SeasonName,
                Year = createChampionshipDTO.Year ?? DateTime.Now.Year
            });

            ChampionshipDTO championshipDTO = new ChampionshipDTO 
            {
                Id = championship.Id,
                SeasonName = createChampionshipDTO.SeasonName,
                Year = createChampionshipDTO.Year ?? DateTime.Now.Year
            };
            return championshipDTO;
        }

        public Task<ChampionshipDTO?> GetByIdAsync(long id)
        {
            // Lógica para obter um campeonato por ID
            return Task.FromResult<ChampionshipDTO?>(null);
        }
    }
}
