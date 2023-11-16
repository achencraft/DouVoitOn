using System.ComponentModel.DataAnnotations;

namespace DouVoitOn.Models
{
    public class TypeAction
    {

        [Key] public int Id { get; set; }
        public string Nom { get; set; }

    }
}
