using Data;

namespace Web.Models
{
    public class NinjaCreateViewModel
    {
        public string Name { get; }
        public int Gold { get; }
        public string SkinUrl { get; }

        public NinjaCreateViewModel()
        {
            
        }

        public NinjaCreateViewModel(Ninja ninja)
        {
            Name = ninja.Name;
            Gold = ninja.Gold;
            SkinUrl = ninja.SkinUrl;
        }
    }
}
