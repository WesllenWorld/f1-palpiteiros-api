using F1Palpiteiros.DTOs;

namespace F1Palpiteiros.Services
{
    public interface IChampionshipService
    {
        Task<ChampionshipDTO> CreateChampionship(CreateChampionshipDTO createChampionshipDTO);
        Task<ChampionshipDTO?> GetByIdAsync(long id);

    }
}
