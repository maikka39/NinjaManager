using Data;

namespace Web.Models
{
    public class NinjaEditViewModel : NinjaCreateViewModel
    {
        public int Id { get; }

        public NinjaEditViewModel(Ninja ninja) : base(ninja)
        {
            Id = ninja.Id;
        }
    }
}
