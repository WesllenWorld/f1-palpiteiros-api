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
            if (string.IsNullOrWhiteSpace(createChampionshipDTO.SeasonName))
            {
                throw new ArgumentException("SeasonName is required.");
            }
            if (createChampionshipDTO.SeasonName.Length > 100)
            {
                throw new ArgumentException("SeasonName cannot exceed 100 characters.");
            }

            //validar ano (dentro dos padrões do int)
            string? inputYear = createChampionshipDTO.Year;
            int? year = null;


            if (inputYear != null)
            {
                if (inputYear.Trim() == "")
                {
                    throw new ArgumentException("Year is required.");
                }

                // if (inputYear != null)
                //{
                if (int.TryParse(inputYear, out int parsedYear))
                {
                    year = parsedYear;
                }
                else
                {
                    throw new ArgumentException($"Invalid year {inputYear}: must be a valid integer");
                }
                //}
            }

            var newChampionship = new Championship(createChampionshipDTO.SeasonName, year);
            //válido -> prossegue para acessar repository
            Championship championship = await _championshiprepository.AddAsync(newChampionship);

            ChampionshipDTO championshipDTO = new ChampionshipDTO
            {
                Id = championship.Id,
                SeasonName = championship.SeasonName,
                Year = championship.Year
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
