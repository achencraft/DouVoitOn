using System.ComponentModel.DataAnnotations;

namespace DouVoitOn.Models
{
    public class Contribution
    {

        [Key] public int Id { get; set; } 
        public User User { get; set; } = null!;
        public TypeAction TypeAction { get; set; } = null!;
        public DateTime Date { get; set; }
        public string? Commentaire { get; set; }
        public Lieu? Lieu { get; set; } = null!;
        public Route? Route { get; set; } = null!;
        public Panneau? Panneau { get; set; } = null!;
    }
}
