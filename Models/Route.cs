using System.ComponentModel.DataAnnotations;

namespace DouVoitOn.Models
{
    public class Route
    {


        [Key] public int Id { get; set; }
        public Lieu lieu { get; set; } = null!;
    }
}
