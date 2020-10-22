using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class NinjaManagerContext : DbContext
    {
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<NinjaEquipment> NinjaEquipment { get; set; }

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
                .WithMany(e => e.NinjaEquipment)
                .HasForeignKey(ne => ne.NinjaId);
            modelBuilder.Entity<NinjaEquipment>()
                .HasOne(n => n.Equipment)
                .WithMany(e => e.NinjaEquipment)
                .HasForeignKey(ne => ne.EquipmentId);

            var ninja = new Ninja {Id = 1, Name = "Cool ninja", Gold = 1500};
            modelBuilder.Entity<Ninja>().HasData(ninja);

            modelBuilder.Entity<Ninja>().HasData(new Ninja {Id = 2, Name = "Awesome_ninja67", Gold = 2000});

            var hat = new Equipment
            {
                Id = 1, Name = "Fancy Hat", Description = "A cheap basic hat which makes you go a little faster.",
                ImageUrl = "/images/equipment/head/golden_helmet.png", Cost = 300, Category = Category.Head,
                Strength = 5, Agility = 200, Intelligence = 30
            };
            modelBuilder.Entity<Equipment>().HasData(hat);
            modelBuilder.Entity<Equipment>()
                .HasData(new Equipment
                {
                    Id = 2, Name = "Pumpkin", Description = "A creepy pumpkin to scare others.",
                    ImageUrl = "/images/equipment/head/carved_pumpkin.png", Cost = 20, Category = Category.Head,
                    Strength = 25, Agility = -50, Intelligence = -40
                });
            modelBuilder.Entity<Equipment>().HasData(new Equipment
            {
                Id = 3, Name = "Diamond Chestplate", Description = "Covers the upper body of the player.",
                ImageUrl = "/images/equipment/chest/diamond_chestplate.png", Cost = 800, Category = Category.Chest,
                Strength = 100, Agility = -50, Intelligence = 20
            });

            modelBuilder.Entity<NinjaEquipment>()
                .HasData(new NinjaEquipment {NinjaId = ninja.Id, EquipmentId = hat.Id});
        }
    }
}
