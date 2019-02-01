using System.ComponentModel.DataAnnotations;

namespace MeetingApp.API.Dtos
{
    public class UserForregisterDto
    {
        [Required]
        public string UserName {get; set;}

        [Required]
[StringLength(8, MinimumLength =4, ErrorMessage ="You must Specify password between 4 and 8 Characters")]
        public string Password {get; set;}


    }
}