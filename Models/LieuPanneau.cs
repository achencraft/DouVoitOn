using System.ComponentModel.DataAnnotations;

namespace DouVoitOn.Models
{
    public class LieuPanneau
    {

        [Key] public int Id { get; set; }
        public Lieu Lieu { get; set; } = null!;
        public Panneau Panneau { get; set; } = null!;
        public int TypeDirection { get; set; }
        public string? NomRoute { get; set; }
        public float distance { get; set; }

    }
}
