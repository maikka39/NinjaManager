using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Data;

namespace Web.Models
{
    public class NinjaViewModel
    {
        public int Id { get; }
        public string Name { get; }
        public int Gold { get; }
        public string SkinUrl { get; }
        public List<NinjaEquipment> Equipment { get; }

        public NinjaViewModel(Ninja ninja)
        {
            Id = ninja.Id;
            Name = ninja.Name;
            Gold = ninja.Gold;
            SkinUrl = ninja.SkinUrl;
            // TODO: NinjaEquipment always returns null
            if (ninja.NinjaEquipment != null)
                Equipment = ninja.NinjaEquipment.ToList();
        }

        public Equipment GetEquipmentFromNinja(Category category)
        {
            // TODO: NinjaEquipment always returns null
            return Equipment?.Find(o => o.Equipment.Category == category)?.Equipment;
        }
    }
}