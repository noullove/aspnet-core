using System.ComponentModel.DataAnnotations;

namespace KCP.Solution.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}