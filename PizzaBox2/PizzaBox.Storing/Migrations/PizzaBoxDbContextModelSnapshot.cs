﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Migrations
{
    [DbContext(typeof(PizzaBoxDbContext))]
    partial class PizzaBoxDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaBox.Domain.PizzaModels.Crust", b =>
                {
                    b.Property<long>("CrustId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CrustId");

                    b.ToTable("CrustDbSet");

                    b.HasData(
                        new
                        {
                            CrustId = 1L,
                            Name = "Deep Dish"
                        },
                        new
                        {
                            CrustId = 2L,
                            Name = "New York Style"
                        },
                        new
                        {
                            CrustId = 3L,
                            Name = "Thin Crust"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.PizzaModels.Pizza", b =>
                {
                    b.Property<long>("PizzaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CrustId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("SizeId")
                        .HasColumnType("bigint");

                    b.HasKey("PizzaId");

                    b.HasIndex("CrustId");

                    b.HasIndex("SizeId");

                    b.ToTable("Pizza");

                    b.HasData(
                        new
                        {
                            PizzaId = 1L,
                            Name = "The Dominic"
                        },
                        new
                        {
                            PizzaId = 2L,
                            Name = "The Fred"
                        },
                        new
                        {
                            PizzaId = 3L,
                            Name = "The Enthusiast"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.PizzaModels.PizzaTopping", b =>
                {
                    b.Property<long>("PizzaId")
                        .HasColumnType("bigint");

                    b.Property<long>("ToppingId")
                        .HasColumnType("bigint");

                    b.HasKey("PizzaId", "ToppingId");

                    b.HasIndex("ToppingId");

                    b.ToTable("PizzaTopping");

                    b.HasData(
                        new
                        {
                            PizzaId = 1L,
                            ToppingId = 1L
                        },
                        new
                        {
                            PizzaId = 2L,
                            ToppingId = 1L
                        },
                        new
                        {
                            PizzaId = 3L,
                            ToppingId = 1L
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.PizzaModels.Size", b =>
                {
                    b.Property<long>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SizeId");

                    b.ToTable("SizeDbSet");

                    b.HasData(
                        new
                        {
                            SizeId = 1L,
                            Name = "Large"
                        },
                        new
                        {
                            SizeId = 2L,
                            Name = "Medium"
                        },
                        new
                        {
                            SizeId = 3L,
                            Name = "Small"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.PizzaModels.Topping", b =>
                {
                    b.Property<long>("ToppingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ToppingId");

                    b.ToTable("ToppingDbSet");

                    b.HasData(
                        new
                        {
                            ToppingId = 1L,
                            Name = "Cheese"
                        },
                        new
                        {
                            ToppingId = 2L,
                            Name = "Pepperoni"
                        },
                        new
                        {
                            ToppingId = 3L,
                            Name = "Tomato Sauce"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.PizzaModels.Pizza", b =>
                {
                    b.HasOne("PizzaBox.Domain.PizzaModels.Crust", "Crust")
                        .WithMany("Pizzas")
                        .HasForeignKey("CrustId");

                    b.HasOne("PizzaBox.Domain.PizzaModels.Size", "Size")
                        .WithMany("Pizzas")
                        .HasForeignKey("SizeId");
                });

            modelBuilder.Entity("PizzaBox.Domain.PizzaModels.PizzaTopping", b =>
                {
                    b.HasOne("PizzaBox.Domain.PizzaModels.Pizza", "Pizza")
                        .WithMany("PizzaTopping")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.PizzaModels.Topping", "Topping")
                        .WithMany("PizzaTopping")
                        .HasForeignKey("ToppingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
