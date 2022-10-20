using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
        : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
            .HasData(
                new Car
                {
                    Id = Guid.Parse("2bb26f6e-bc21-471c-b4fc-9dfbe359ead1"),
                    Model = "Ford",
                    Name = "John",
                    Category = "heavy lifter",
                    ProductionYear = 1955
                },
                new Car
                {
                    Id = Guid.Parse("9f6da19c-68ca-4550-980b-aa21c7bfddc4"),
                    Model = "Opel",
                    Name = "Doe",
                    Category = "personal",
                    ProductionYear = 2022
                },
                new Car
                {
                    Id = Guid.Parse("dd0070bd-d465-4dc8-9b60-4482ef53ad39"),
                    Model = "Hyundai",
                    Name = "John",
                    Category = "heavy lifter",
                    ProductionYear = 1933
                },
                new Car
                {
                    Id = Guid.Parse("3924250f-0c42-48af-9520-c78e230c599f"),
                    Model = "Ford",
                    Name = "Doe",
                    Category = "personal",
                    ProductionYear = 2021
                },
                new Car
                {
                    Id = Guid.Parse("3032144a-8aa1-4884-a4bc-c44919e40370"),
                    Model = "Opel",
                    Name = "John",
                    Category = "heavy lifter",
                    ProductionYear = 1939
                },
                new Car
                {
                    Id = Guid.Parse("6ee99129-bba5-459a-9d01-81625209e055"),
                    Model = "Hyundai",
                    Name = "Doe",
                    Category = "personal",
                    ProductionYear = 2025
                }
            );
        }
    }
}

