using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(int.MaxValue, MinimumLength=8,ErrorMessage = "password must be min of 8 characters")]
        public string Password { get; set; }
    }
}