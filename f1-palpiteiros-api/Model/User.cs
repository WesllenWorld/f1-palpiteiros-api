using UserType = F1Palpiteiros.Model.Enums.ENUM_UserType;
namespace F1Palpiteiros.Model
{
    
    public class User
    {
        //inicializar com .Empty é uma boa ideia?
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        //public string? UserNickname { get; set; }
        public string UserNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public UserType Role { get; set; } = UserType.User;
        public List<CompetitorStanding>? CompetitorStandings { get; set; }
        public List<Guess>? Guesses { get; set; }
    }
}
