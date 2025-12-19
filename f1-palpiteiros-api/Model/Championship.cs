using System.Collections;

namespace F1Palpiteiros.Model
{
    public class Championship
    {
        public long Id { get; set; }
        public string SeasonName { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public ICollection<CompetitorStanding>? Competitors { get; set; }
        public ICollection<RaceWeek>? RaceWeeks { get; set; }
        public ICollection<RaceWeekEvent>? Events { get; set; }
        public ICollection<ChampionshipDriver>? Drivers { get; set; } = new List<ChampionshipDriver>();

    }
}
