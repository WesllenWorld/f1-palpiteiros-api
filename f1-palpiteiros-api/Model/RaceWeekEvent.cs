namespace F1Palpiteiros.Model.Enums
{
    public class RaceWeekEvent
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public List<Guess> Guesses { get; set; }

        public RaceWeekEvent(string name, string description, DateTime startDate)
        {
            Name = name;
            Description = description;
            StartDate = startDate;
        }
    }
}
