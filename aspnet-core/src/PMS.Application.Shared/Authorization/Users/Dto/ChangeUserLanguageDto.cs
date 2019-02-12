using System.ComponentModel.DataAnnotations;

namespace PMS.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
