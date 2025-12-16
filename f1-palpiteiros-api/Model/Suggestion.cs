namespace F1Palpiteiros.Model
{
    public class Suggestion
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public long GuessId { get; set; }
        public Guess Guess { get; set; } = null!;
        public Driver Driver { get; set; } = null!;
        public long DriverId { get; set; }

       
    }
}
