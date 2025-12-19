namespace F1Palpiteiros.Model
{
    public class RaceWeekEvent
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public ICollection<Guess> Guesses { get; set; } = new List<Guess>();
        public long RaceWeekId { get; set; }
        public RaceWeek RaceWeek { get; set; } = null!;

        /*
         public void disregardEvent()
         {
             // lógica para desconsiderar o evento
         }

         */
    }
}
