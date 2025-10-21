namespace F1Palpiteiros.Model
{
    public class Driver
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string Number {  get; set; }

        public Driver(string name, string abbreviation, string number)
        {
            Name = name;
            Abbreviation = abbreviation;
            Number = number;
        }
    }
}
