using System.ComponentModel.DataAnnotations;

namespace DouVoitOn.Models
{
    public class Lieu
    {

        [Key] public int Id { get; set; }
        public string Nom { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string? Pays { get; set; }
        public string? Ville { get; set; }
        public string? Adresse { get; set; }
        public string? Description { get; set; }
    }
}
