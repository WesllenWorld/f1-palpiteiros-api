namespace F1Palpiteiros.Model
{
    public class Driver
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string Number {  get; set; }
        public string Team { get; set; }
        public bool IsMainDriver { get; set; }

        public ICollection<Suggestion> Suggestions { get; set; } = new List<Suggestion>(); 



    }
}
