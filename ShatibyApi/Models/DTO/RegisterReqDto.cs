using System.ComponentModel.DataAnnotations;

namespace ShatibyApi.Models.DTO
{
    public class RegisterReqDto
    {
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string[] Roles  { get; set; }
    }
}
