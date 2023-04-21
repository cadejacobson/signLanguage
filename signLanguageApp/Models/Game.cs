using signLanguageApp.ViewModels;

namespace signLanguageApp.Models
{
    public class Game
    {
        public int Id { get; set; }
        public SignViewModel Sign1 { get; set; }
        public SignViewModel Sign2 { get; set; }
        public int CorrectItem { get; set; }
    }
}
