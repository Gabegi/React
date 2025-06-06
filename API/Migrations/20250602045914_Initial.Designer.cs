﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250602045914_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.5");

            modelBuilder.Entity("API.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Rhône Valley",
                            Description = "A bold, complex red wine with notes of dark fruit, spice, and herbs.",
                            Name = "Châteauneuf-du-Pape",
                            PictureUrl = "/images/chateauneuf.png",
                            Price = 49.99m,
                            QuantityInStock = 20,
                            Type = "Red Wine"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Rhône Valley",
                            Description = "Rich and powerful with deep cherry and pepper flavors.",
                            Name = "Gigondas",
                            PictureUrl = "/images/gigondas.png",
                            Price = 34.99m,
                            QuantityInStock = 15,
                            Type = "Red Wine"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Rhône Valley",
                            Description = "Elegant and full-bodied, blending Grenache and Syrah grapes.",
                            Name = "Vacqueyras",
                            PictureUrl = "/images/vacqueyras.png",
                            Price = 29.99m,
                            QuantityInStock = 18,
                            Type = "Red Wine"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Rhône Valley",
                            Description = "Dry and intense, known for its bold tannins and ripe fruit profile.",
                            Name = "Rasteau",
                            PictureUrl = "/images/rasteau.png",
                            Price = 27.99m,
                            QuantityInStock = 12,
                            Type = "Red Wine"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Rhône Valley",
                            Description = "Spicy and velvety, distinct from its strong neighbours.",
                            Name = "Beaumes-de-Venise (Red)",
                            PictureUrl = "/images/beaumes.png",
                            Price = 25.99m,
                            QuantityInStock = 10,
                            Type = "Red Wine"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Rhône Valley",
                            Description = "Spicy and structured with good aging potential.",
                            Name = "Vinsobres",
                            PictureUrl = "/images/vinsobres.png",
                            Price = 23.99m,
                            QuantityInStock = 14,
                            Type = "Red Wine"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Rhône Valley",
                            Description = "Balanced and aromatic, with red berry and herbal notes.",
                            Name = "Cairanne",
                            PictureUrl = "/images/cairanne.png",
                            Price = 22.99m,
                            QuantityInStock = 16,
                            Type = "Red Wine"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Rhône Valley",
                            Description = "A deep, brooding Syrah with intense black fruit, smoke, and spice.",
                            Name = "Cornas",
                            PictureUrl = "/images/cornas.png",
                            Price = 44.99m,
                            QuantityInStock = 11,
                            Type = "Red Wine"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "Rhône Valley",
                            Description = "A balanced Syrah showcasing red berries, pepper, and earthy minerality.",
                            Name = "Crozes-Hermitage",
                            PictureUrl = "/images/crozes.png",
                            Price = 38.5m,
                            QuantityInStock = 15,
                            Type = "Red Wine"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
