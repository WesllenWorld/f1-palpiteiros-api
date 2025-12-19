namespace F1Palpiteiros.Model
{
    public class Driver
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Abbreviation { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string Team { get; set; } = string.Empty;
        public bool IsMainDriver { get; set; }
        public bool Active { get; set; }
        public ICollection<Suggestion> Suggestions { get; set; } = new List<Suggestion>();
        public ICollection<ChampionshipDriver> Championships { get; set; }
        = new List<ChampionshipDriver>();



    }
}
