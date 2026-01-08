using System.Collections;

namespace F1Palpiteiros.Model
{
    public class Championship
    {
        public long Id { get; set; }
        public string SeasonName { get; set; } = string.Empty;
        public int Year { get; private set; }
        public ICollection<CompetitorStanding> Competitors { get; set; } = new List<CompetitorStanding>();
        public ICollection<RaceWeek> RaceWeeks { get; set; } = new List<RaceWeek>();
        public ICollection<RaceWeekEvent> Events { get; set; } = new List<RaceWeekEvent>();
        public ICollection<ChampionshipDriver> Drivers { get; set; } = new List<ChampionshipDriver>();

        public Championship() { }
        public Championship(int? year = null)
        {
            Year = year ?? DateTime.Now.Year;
        }

    }
}
