using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Ninja
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string Name { get; set; }

        [Required] [Range(0, int.MaxValue)] public int Gold { get; set; }
        
        public ICollection<NinjaEquipment> NinjaEquipment { get; set; }

    }
}
