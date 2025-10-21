namespace F1Palpiteiros.Model
{
    public class PositionGuess
    {
        public long Id { get; set; }
        private int Position {  get; set; }
        private Driver Driver;

        public PositionGuess(int position, Driver driver)
        {
            Position = position;
            this.Driver = driver;
        }
    }
}
