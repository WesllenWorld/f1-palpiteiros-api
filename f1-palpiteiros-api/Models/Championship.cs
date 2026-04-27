using System.Collections;

namespace F1Palpiteiros.Model
{
    public class Championship
    {
        public long Id { get; set; }
        public string SeasonName { get; set; } = string.Empty;
        public int Year { get; set ; }
        public ICollection<CompetitorStanding> Competitors { get; set; } = new List<CompetitorStanding>();
        public ICollection<RaceWeek> RaceWeeks { get; set; } = new List<RaceWeek>();
        public ICollection<RaceWeekEvent> Events { get; set; } = new List<RaceWeekEvent>();
        public ICollection<ChampionshipDriver> Drivers { get; set; } = new List<ChampionshipDriver>();

        protected Championship() { }
        public Championship(string seasonName, int? year = null)
        {
            SeasonName = seasonName;
            Year = year ?? DateTime.Now.Year;
        }

    }
}
