using Data;

namespace Web.Models
{
    public class NinjaEditViewModel
    {
        public int Id { get; }
        public string Name { get; }
        public int Gold { get; }
        public string SkinUrl { get; }

        public NinjaEditViewModel(Ninja ninja)
        {
            Id = ninja.Id;
            Name = ninja.Name;
            Gold = ninja.Gold;
            SkinUrl = ninja.SkinUrl;
        }
    }
}
