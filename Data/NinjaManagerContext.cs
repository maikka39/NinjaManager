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
            
            var leggings1 = new Equipment
            {
                Id = 7, Name = "Chainmail Leggings", Description = "Nice thick leather to keep your butt warm.",
                ImageUrl = "/images/equipment/leggings/chainmail_leggings.png", Cost = 160, Category = Category.Leggings,
                Strength = 10, Agility = 40, Intelligence = 30
            };
            var leggings2 = new Equipment
            {
                Id = 8, Name = "Iron Leggings", Description = "Just some nice pants.",
                ImageUrl = "/images/equipment/leggings/iron_leggings.png", Cost = 320, Category = Category.Leggings,
                Strength = 60, Agility = -80, Intelligence = 100
            };
            var leggings3 = new Equipment
            {
                Id = 9, Name = "Diamond Leggings", Description = "Helps just a bit.",
                ImageUrl = "/images/equipment/leggings/diamond_leggings.png", Cost = 470, Category = Category.Leggings,
                Strength = 360, Agility = -10, Intelligence = -40
            };
            
            var boots1 = new Equipment
            {
                Id = 10, Name = "Leather Boots", Description = "Nice thick leather to keep your feet warm.",
                ImageUrl = "/images/equipment/boots/leather_boots.png", Cost = 90, Category = Category.Boots,
                Strength = 0, Agility = 110, Intelligence = -30
            };
            var boots2 = new Equipment
            {
                Id = 11, Name = "Iron Boots", Description = "Just some nice shiny shoes.",
                ImageUrl = "/images/equipment/boots/iron_boots.png", Cost = 220, Category = Category.Boots,
                Strength = 160, Agility = -30, Intelligence = 10
            };
            var boots3 = new Equipment
            {
                Id = 12, Name = "Netherite Boots", Description = "Heavy metal rock shoes.",
                ImageUrl = "/images/equipment/boots/netherite_boots.png", Cost = 440, Category = Category.Boots,
                Strength = 160, Agility = 20, Intelligence = -30
            };
            
            modelBuilder.Entity<Equipment>().HasData(boots1, boots2, boots3);
            
            var sword1 = new Equipment
            {
                Id = 13, Name = "Golden Sword", Description = "Cheap gold but it's good looking.",
                ImageUrl = "/images/equipment/sword/golden_sword.png", Cost = 40, Category = Category.Sword,
                Strength = 20, Agility = 10, Intelligence = 10
            };
            var sword2 = new Equipment
            {
                Id = 14, Name = "Iron Sword", Description = "Will do the trick.",
                ImageUrl = "/images/equipment/sword/iron_sword.png", Cost = 220, Category = Category.Sword,
                Strength = 160, Agility = -30, Intelligence = 10
            };
            var sword3 = new Equipment
            {
                Id = 15, Name = "Netherite Sword", Description = "Heavy metal blade of doom.",
                ImageUrl = "/images/equipment/sword/netherite_sword.png", Cost = 640, Category = Category.Sword,
                Strength = 430, Agility = 80, Intelligence = 60
            };
            
            modelBuilder.Entity<Equipment>().HasData(sword1, sword2, sword3);
            
            var potion1 = new Equipment
            {
                Id = 16, Name = "Night Vision Potion", Description = "To see everything.",
                ImageUrl = "/images/equipment/potion/Potion_of_Night_Vision.gif", Cost = 300, Category = Category.Potion,
                Strength = 0, Agility = 0, Intelligence = 300
            };
            var potion2 = new Equipment
            {
                Id = 17, Name = "Regeneration potion", Description = "If you need some more time.",
                ImageUrl = "/images/equipment/potion/Potion_of_Regeneration.gif", Cost = 300, Category = Category.Potion,
                Strength = 300, Agility = 0, Intelligence = 0
            };
            var potion3 = new Equipment
            {
                Id = 18, Name = "Swiftness potion", Description = "If you're in a hurry.",
                ImageUrl = "/images/equipment/potion/Potion_of_Swiftness.gif", Cost = 300, Category = Category.Potion,
                Strength = 0, Agility = 300, Intelligence = 0
            };
            
            modelBuilder.Entity<Equipment>().HasData(potion1, potion2, potion3);
            
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
