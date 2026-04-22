using F1Palpiteiros.Context;
using F1Palpiteiros.Model;

namespace F1Palpiteiros.Repositories
{
    public class ChampionshipRepository : IChampionshipRepository
    {
        private readonly AppDbContext _context;

        public ChampionshipRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Championship> AddAsync(Championship championship)
        {
            _context.Championships.Add(championship);
            await _context.SaveChangesAsync();
            return championship;
        }

        public Task<Championship?> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
