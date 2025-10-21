using System.Collections;

namespace F1Palpiteiros.Model
{
    public class Championship
    {
        public int Id { get; set; }
        public string SeasonName { get; set; } = string.Empty;
        public List<CompetitorStanding>? Competitors { get; set; }
        public List<RaceWeek>? RaceWeeks { get; set; }


    }
}
