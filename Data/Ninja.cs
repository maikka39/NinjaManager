using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Ninja
    {
        [Key]
        [StringLength(40, MinimumLength = 1)]
        public string Name { get; set; }

        [Required] [Range(0, int.MaxValue)] public int Gold { get; set; }
    }
}