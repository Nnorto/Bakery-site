using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bakery.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageFileName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Аппетитный мини-торт из моркови, усыпанный нарезанным миндалем", "carrot_cake.jpg", "Морковный торт", 539m },
                    { 2, "Восхитительный лимонный пирог с свежим меренгом, приготовленным до совершенства", "lemon_tart.jpg", "Лимонный пирог", 599m },
                    { 3, "Искушающие ванильные и шоколадные капкейки", "cupcakes.jpg", "Капкейки", 359m },
                    { 4, "Свежевыпеченный хлеб во французском стиле", "bread.jpg", "Хлеб", 89m },
                    { 5, "Грушевый пирог с глазурью, посыпанный нарезанным миндалем и щепоткой корицы", "pear_tart.jpg", "Грушевый пирог", 359m },
                    { 6, "Пышный шоколадный крем покрывает этот торт, созданный для любителей шоколада", "chocolate_cake.jpg", "Шоколадный торт", 539m },
                    { 7, "Настоящая американская классика — нежный чизкейк из сливочно-творожной начинки с ванильной ноткой на тонкой песочно-миндальной подложке. Сверху десерт покрыт желе из абрикосового конфитюра, украшен свежей малиной и сахарной пудрой.", "cheesecake.jpg", "Чизкейк", 200m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
