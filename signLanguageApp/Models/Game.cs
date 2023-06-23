using signLanguageApp.ViewModels;

namespace signLanguageApp.Models
{
    public class Game
    {
        public int Id { get; set; }
        public SignViewModel Signs { get; set; }
        public int CorrectItem { get; set; }
    }
}
