// <auto-generated />
using System;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Backend.Data.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProductionYear")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2bb26f6e-bc21-471c-b4fc-9dfbe359ead1"),
                            Category = "heavy lifter",
                            Model = "Ford",
                            Name = "John",
                            ProductionYear = 1955
                        },
                        new
                        {
                            Id = new Guid("9f6da19c-68ca-4550-980b-aa21c7bfddc4"),
                            Category = "personal",
                            Model = "Opel",
                            Name = "Doe",
                            ProductionYear = 2022
                        },
                        new
                        {
                            Id = new Guid("dd0070bd-d465-4dc8-9b60-4482ef53ad39"),
                            Category = "heavy lifter",
                            Model = "Hyundai",
                            Name = "John",
                            ProductionYear = 1933
                        },
                        new
                        {
                            Id = new Guid("3924250f-0c42-48af-9520-c78e230c599f"),
                            Category = "personal",
                            Model = "Ford",
                            Name = "Doe",
                            ProductionYear = 2021
                        },
                        new
                        {
                            Id = new Guid("3032144a-8aa1-4884-a4bc-c44919e40370"),
                            Category = "heavy lifter",
                            Model = "Opel",
                            Name = "John",
                            ProductionYear = 1939
                        },
                        new
                        {
                            Id = new Guid("6ee99129-bba5-459a-9d01-81625209e055"),
                            Category = "personal",
                            Model = "Hyundai",
                            Name = "Doe",
                            ProductionYear = 2025
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
