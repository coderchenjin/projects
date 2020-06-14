using System.ComponentModel.DataAnnotations;

namespace Project.ABP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}