using signLanguageApp.Models;

namespace signLanguageApp.ViewModels
{
    public class SignViewModel
    {
        public SignViewModel() 
        { 
            //empty constructor
        }

        public SignViewModel(Sign sign)
        {
            if(sign != null)
            {
                Id = sign.Id;
                Name = sign.Name;
                Image = sign.Image;
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public IEnumerable<Sign> Signs { get; set; }
    }
}
