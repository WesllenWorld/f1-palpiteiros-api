namespace F1Palpiteiros.Model
{
    public class ChampionshipDriver
    {
        public long ChampionshipId { get; set; }
        public Championship Championship { get; set; } = null!;
        public long DriverId { get; set; }
        public Driver Driver { get; set; } = null!;
    }
}
