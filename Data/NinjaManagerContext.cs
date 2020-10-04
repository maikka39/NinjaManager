using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class NinjaManagerContext : DbContext
    {
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Equipment> Equipment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=localhost;Database=NinjaManager;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ninja>().HasData(new Ninja {Name = "Awesome_ninja67", Gold = 2000});

            modelBuilder.Entity<Equipment>().HasData(new Equipment
                {Name = "Fancy Hat", Cost = 300, Category = Category.Head, Strength = 5, Agility = 200, Intelligence = 30});
            modelBuilder.Entity<Equipment>()
                .HasData(new Equipment {Name = "Pumpkin", Cost = 20, Category = Category.Head, Strength = 15, Agility = 200, Intelligence = -40});
            modelBuilder.Entity<Equipment>().HasData(new Equipment
                {Name = "Diamond Chestplate", Cost = 800, Category = Category.Chest, Strength = 100, Agility = -50, Intelligence = 20});
        }
    }
}
