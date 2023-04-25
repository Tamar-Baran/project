using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class User
    {
        [EmailAddress(ErrorMessage = "email not valid")]
        public string email { get; set; }

        public string password { get; set; }

        [StringLength(20, ErrorMessage = "password length must be between 5-20", MinimumLength = 5)]
        public string? firstName { get; set; }
        public string? lastName { get; set; }

        public int? id { get; set; }
    }
}
