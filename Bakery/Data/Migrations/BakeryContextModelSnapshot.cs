﻿// <auto-generated />
using Bakery.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bakery.Data.Migrations
{
    [DbContext(typeof(BakeryContext))]
    partial class BakeryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("Bakery.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("ImageFileName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Аппетитный мини-торт из моркови, усыпанный нарезанным миндалем",
                            ImageName = "carrot_cake.jpg",
                            Name = "Морковный торт",
                            Price = 539m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Восхитительный лимонный пирог с свежим меренгом, приготовленным до совершенства",
                            ImageName = "lemon_tart.jpg",
                            Name = "Лимонный пирог",
                            Price = 599m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Искушающие ванильные и шоколадные капкейки",
                            ImageName = "cupcakes.jpg",
                            Name = "Капкейки",
                            Price = 359m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Свежевыпеченный хлеб во французском стиле",
                            ImageName = "bread.jpg",
                            Name = "Хлеб",
                            Price = 89m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Грушевый пирог с глазурью, посыпанный нарезанным миндалем и щепоткой корицы",
                            ImageName = "pear_tart.jpg",
                            Name = "Грушевый пирог",
                            Price = 359m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Пышный шоколадный крем покрывает этот торт, созданный для любителей шоколада",
                            ImageName = "chocolate_cake.jpg",
                            Name = "Шоколадный торт",
                            Price = 539m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Настоящая американская классика — нежный чизкейк из сливочно-творожной начинки с ванильной ноткой на тонкой песочно-миндальной подложке. Сверху десерт покрыт желе из абрикосового конфитюра, украшен свежей малиной и сахарной пудрой.",
                            ImageName = "cheesecake.jpg",
                            Name = "Чизкейк",
                            Price = 200m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
