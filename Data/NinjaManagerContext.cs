using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class NinjaManagerContext : DbContext
    {
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<NinjaEquipment> NinjaEquipments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=localhost;Database=NinjaManager;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NinjaEquipment>().HasKey(ne => new {ne.NinjaId, ne.EquipmentId});
            modelBuilder.Entity<NinjaEquipment>()
                .HasOne(ne => ne.Ninja)
                .WithMany(e => e.Equipments)
                .HasForeignKey(ne => ne.NinjaId);
            modelBuilder.Entity<NinjaEquipment>()
                .HasOne(n => n.Equipment)
                .WithMany(e => e.Ninjas)
                .HasForeignKey(ne => ne.EquipmentId);

            var ninja1 = new Ninja {Id = 1, Name = "Cool ninja", Gold = 1500};
            var ninja2 = new Ninja {Id = 2, Name = "Awesome_ninja67", Gold = 2000};
            var ninja3 = new Ninja {Id = 3, Name = "Blockplacer", Gold = 1200};
            var ninja4 = new Ninja {Id = 4, Name = "Stealthy", Gold = 3200};
            var ninja5 = new Ninja {Id = 5, Name = "Epicness", Gold = 4000};
            var ninja6 = new Ninja {Id = 6, Name = "Epic_Fat", Gold = 2500};
            
            modelBuilder.Entity<Ninja>().HasData(ninja1, ninja2, ninja3, ninja4, ninja5, ninja6);

            var helmet1 = new Equipment
            {
                Id = 1, Name = "Fancy Hat", Description = "A cheap basic hat which makes you go a little faster.",
                ImageUrl = "/images/equipment/helmet/golden_helmet.png", Cost = 300, Category = Category.Helmet,
                Strength = 5, Agility = 200, Intelligence = 30
            };
            var helmet2 = new Equipment
            {
                Id = 2, Name = "Shelly", Description = "If you scared just hide in your shell.",
                ImageUrl = "/images/equipment/helmet/turtle_shell.png", Cost = 600, Category = Category.Helmet,
                Strength = 140, Agility = -200, Intelligence = 20
            };
            var helmet3 = new Equipment
            {
                Id = 3, Name = "Pumpkin", Description = "A creepy pumpkin to scare others.",
                ImageUrl = "/images/equipment/helmet/carved_pumpkin.png", Cost = 240, Category = Category.Helmet,
                Strength = -10, Agility = -50, Intelligence = 130
            };
            
            modelBuilder.Entity<Equipment>().HasData(helmet1, helmet2, helmet3);

            var chestplate1 = new Equipment
            {
                Id = 4, Name = "Diamond Chestplate", Description = "Covers the upper body of the player.",
                ImageUrl = "/images/equipment/chest/diamond_chestplate.png", Cost = 800, Category = Category.Chestplate,
                Strength = 100, Agility = -40, Intelligence = 20
            };
            var chestplate2 = new Equipment
            {
                Id = 5, Name = "Netherite Chestplate", Description = "Even lava can't beat this",
                ImageUrl = "/images/equipment/chest/netherite_chestplate.png", Cost = 1200, Category = Category.Chestplate,
                Strength = 300, Agility = -50, Intelligence = 40
            };
            var chestplate3 = new Equipment
            {
                Id = 6, Name = "Leather Chestplate", Description = "Helps a bit.",
                ImageUrl = "/images/equipment/chest/leather_tunic.png", Cost = 350, Category = Category.Chestplate,
                Strength = 10, Agility = 150, Intelligence = -70
            };

            modelBuilder.Entity<Equipment>().HasData(chestplate1, chestplate2, chestplate3);
            
            modelBuilder.Entity<NinjaEquipment>()
                .HasData(new NinjaEquipment {NinjaId = ninja1.Id, EquipmentId = helmet3.Id}, new NinjaEquipment {NinjaId = ninja1.Id, EquipmentId = chestplate2.Id});
            modelBuilder.Entity<NinjaEquipment>()
                .HasData(new NinjaEquipment {NinjaId = ninja3.Id, EquipmentId = helmet1.Id}, new NinjaEquipment {NinjaId = ninja3.Id, EquipmentId = chestplate3.Id});
            modelBuilder.Entity<NinjaEquipment>()
                .HasData(new NinjaEquipment {NinjaId = ninja6.Id, EquipmentId = helmet2.Id}, new NinjaEquipment {NinjaId = ninja6.Id, EquipmentId = chestplate1.Id});
            modelBuilder.Entity<NinjaEquipment>()
                .HasData(new NinjaEquipment {NinjaId = ninja4.Id, EquipmentId = helmet2.Id}, new NinjaEquipment {NinjaId = ninja4.Id, EquipmentId = chestplate3.Id});
        }
    }
}
