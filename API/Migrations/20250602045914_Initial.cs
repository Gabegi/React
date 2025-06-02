using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    QuantityInStock = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[,]
                {
                    { 1, "Rhône Valley", "A bold, complex red wine with notes of dark fruit, spice, and herbs.", "Châteauneuf-du-Pape", "/images/chateauneuf.png", 49.99m, 20, "Red Wine" },
                    { 2, "Rhône Valley", "Rich and powerful with deep cherry and pepper flavors.", "Gigondas", "/images/gigondas.png", 34.99m, 15, "Red Wine" },
                    { 3, "Rhône Valley", "Elegant and full-bodied, blending Grenache and Syrah grapes.", "Vacqueyras", "/images/vacqueyras.png", 29.99m, 18, "Red Wine" },
                    { 4, "Rhône Valley", "Dry and intense, known for its bold tannins and ripe fruit profile.", "Rasteau", "/images/rasteau.png", 27.99m, 12, "Red Wine" },
                    { 5, "Rhône Valley", "Spicy and velvety, distinct from its strong neighbours.", "Beaumes-de-Venise (Red)", "/images/beaumes.png", 25.99m, 10, "Red Wine" },
                    { 6, "Rhône Valley", "Spicy and structured with good aging potential.", "Vinsobres", "/images/vinsobres.png", 23.99m, 14, "Red Wine" },
                    { 7, "Rhône Valley", "Balanced and aromatic, with red berry and herbal notes.", "Cairanne", "/images/cairanne.png", 22.99m, 16, "Red Wine" },
                    { 8, "Rhône Valley", "A deep, brooding Syrah with intense black fruit, smoke, and spice.", "Cornas", "/images/cornas.png", 44.99m, 11, "Red Wine" },
                    { 9, "Rhône Valley", "A balanced Syrah showcasing red berries, pepper, and earthy minerality.", "Crozes-Hermitage", "/images/crozes.png", 38.5m, 15, "Red Wine" }
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
