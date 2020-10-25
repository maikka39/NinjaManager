using Data;

namespace Web.Models
{
    public class NinjaIndexViewModel
    {
        public int Id { get; }
        public string Name { get; }
        public int Gold { get; }

        public NinjaIndexViewModel(Ninja ninja)
        {
            Id = ninja.Id;
            Name = ninja.Name;
            Gold = ninja.Gold;
        }
    }
}
