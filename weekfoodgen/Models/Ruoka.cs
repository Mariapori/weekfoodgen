namespace weekfoodgen.Models
{
    public class Ruoka
    {
        public int Id { get; set; }
        public string Nimi { get; set; }
        public string Omistaja { get; set; }
        public List<RaakaAine>? RaakaAineet { get; set; }
    }
}
