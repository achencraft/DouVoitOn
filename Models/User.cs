using System.ComponentModel.DataAnnotations;

namespace DouVoitOn.Models
{
    public class User
    {

        [Key] public int Id { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string PasswordHash { get; set; }
        public Role Role { get; set; }
        public DateTime Date_Inscription { get; set; }

    }
}
