using System.ComponentModel.DataAnnotations;

namespace ShatibyApi.Models.DTO
{
    public class LoginReqDto
    {
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
