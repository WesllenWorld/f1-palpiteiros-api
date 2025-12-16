namespace F1Palpiteiros.Model
{
    public class CompetitorStanding
    {
        public long Id { get; set; }
        public float Points { get; set; }
        public string Nickname { get; set; } = string.Empty;
        public Championship? Championship { get; set; }
        public User User { get; set; } = null!;
        public long UserId { get; set; }
    }
}
