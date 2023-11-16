using System.ComponentModel.DataAnnotations;

namespace DouVoitOn.Models
{
    public class TypePanneau
    {

        [Key] public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }

    }
}
