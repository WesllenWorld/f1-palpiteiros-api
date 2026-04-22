using F1Palpiteiros.Model;

namespace F1Palpiteiros.Repositories
{
    public interface IChampionshipRepository
    {
        Task<Championship> AddAsync(Championship championship);
        Task<Championship?> GetByIdAsync(long id);
    }
}
