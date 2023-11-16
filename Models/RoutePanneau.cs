using System.ComponentModel.DataAnnotations;

namespace DouVoitOn.Models
{
    public class RoutePanneau
    {

        [Key] public int Id { get; set; }
        public Route Route { get; set; } = null!;
        public Panneau Panneau { get; set; } = null!;
        public int Ordre { get; set; }
    }
}
