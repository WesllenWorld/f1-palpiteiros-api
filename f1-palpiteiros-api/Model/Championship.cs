using System.Collections;

namespace F1Palpiteiros.Model
{
    public class Championship
    {
        public long Id { get; set; }
        public string SeasonName { get; set; } = string.Empty;
        public List<CompetitorStanding>? Competitors { get; set; }
        public List<RaceWeek>? RaceWeeks { get; set; }
        public string Year { get; set; } = string.Empty;

    }
}
