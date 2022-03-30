namespace weekfoodgen.Models
{
    public class ViikkoLista
    {
        public int Id { get; set; }
        public int Viikko { get; set; }
        public int Vuosi { get; set; }
        public string Omistaja { get; set; }
        public List<Ruoka>? Ruuat { get; set; }

    }
}
