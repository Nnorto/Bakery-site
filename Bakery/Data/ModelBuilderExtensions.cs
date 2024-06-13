using Bakery.Models;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Морковный торт",
                    Description = "Аппетитный мини-торт из моркови, усыпанный нарезанным миндалем",
                    Price = 539m, // ≈ $8.99 * 60
                    ImageName = "carrot_cake.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Лимонный пирог",
                    Description = "Восхитительный лимонный пирог с свежим меренгом, приготовленным до совершенства",
                    Price = 599m, // ≈ $9.99 * 60
                    ImageName = "lemon_tart.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Капкейки",
                    Description = "Искушающие ванильные и шоколадные капкейки",
                    Price = 359m, // ≈ $5.99 * 60
                    ImageName = "cupcakes.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Хлеб",
                    Description = "Свежевыпеченный хлеб во французском стиле",
                    Price = 89m, // ≈ $1.49 * 60
                    ImageName = "bread.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Грушевый пирог",
                    Description = "Грушевый пирог с глазурью, посыпанный нарезанным миндалем и щепоткой корицы",
                    Price = 359m, // ≈ $5.99 * 60
                    ImageName = "pear_tart.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name = "Шоколадный торт",
                    Description = "Пышный шоколадный крем покрывает этот торт, созданный для любителей шоколада",
                    Price = 539m, // ≈ $8.99 * 60
                    ImageName = "chocolate_cake.jpg"
                },
                new Product
                {
                    Id = 7,
                    Name = "Чизкейк",
                    Description = "Настоящая американская классика — нежный чизкейк из сливочно-творожной начинки с ванильной ноткой на тонкой песочно-миндальной подложке. Сверху десерт покрыт желе из абрикосового конфитюра, украшен свежей малиной и сахарной пудрой.",
                    Price = 200m, // ≈ $8.99 * 60
                    ImageName = "cheesecake.jpg"
                }
            );
            return modelBuilder;
        }
    }
}
