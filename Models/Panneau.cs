using System.ComponentModel.DataAnnotations;

namespace DouVoitOn.Models
{
    public class Panneau
    {


        [Key] public int Id { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int Cap { get; set; }
        public string? Pays { get; set; }
        public string? Ville { get; set; }
        public string? Adresse { get; set; }
        public string? Description { get; set; }
    }
}
