using System.ComponentModel.DataAnnotations;

namespace SOMCH.DTOs
{
    public class LoginDTO
    {

        [Required(ErrorMessage = "Enter Password."),
         Display(Name ="Password")
            ]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Username."),
         MinLength(3, ErrorMessage = "User name msut have 3 or more characters"),
         Display(Name = "Username")
        ]
        public string Username { get; set; }

        public Dictionary<string, string>? ErrorMessages { get; set; }
    }
}
