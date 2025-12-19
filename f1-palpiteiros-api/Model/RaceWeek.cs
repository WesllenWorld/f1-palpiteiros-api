namespace F1Palpiteiros.Model
{
    public class RaceWeek
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Championship? Championship { get; set; }
        public long ChampionshipId { get; set; }
        public ICollection<RaceWeekEvent>? Events { get; set; } = new List<RaceWeekEvent>();


        /*
        public double calculate()
        {
            // lógica de cálculo de pontos do campeonato
        }

        public void updateStandings()
        {
            // lógica para atualizar a classificação do campeonato
        }

        public void scheduleEvents()
        {
            // lógica para agendar eventos do campeonato
        }

        public void displayInfo()
        {
            // lógica para exibir informações do campeonato
        }

        //metodo para desconsiderar o final de semana
        public void disregardRaceWeek()
        {
            // lógica para desconsiderar o final de semana
        }


        */

    }
}
