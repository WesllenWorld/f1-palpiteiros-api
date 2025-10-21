using GuessType = F1Palpiteiros.Model.Enums.ENUM_GuessType;
namespace F1Palpiteiros.Model
{
    public class Guess
    {
        public long Id { get; set; }
        public GuessType GuessType { get; set; }
        public DateTime? CreatedDate { get; set; }
        //lembrar de colocar o date no submit e comparar com o horário de início lá no RaceWeekEvent

    }
}
