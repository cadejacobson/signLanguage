using System.ComponentModel.DataAnnotations;

namespace signLanguageApp.Models
{
    public class Sign
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
