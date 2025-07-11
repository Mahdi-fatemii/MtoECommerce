using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MtoECommerce.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoriesAndProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, "Shirts", "shirts" },
                    { 2, "Dress", "dress" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price", "Slug" },
                values: new object[,]
                {
                    { 1, 1, "A Nice Blue Polo Shirt for Men", "PoloShirt.jpg", "Polo Shirt", 22.79m, "polo-shirt" },
                    { 2, 2, "Black Strappy Volume-Hem Midi Dress", "BlackDress1.jpg", "Parina Black Dress", 127.99m, "parina-black-dress" },
                    { 3, 2, "Lemon Asymmetric Neckline High-Split Maxi Dress", "LemonDress1.jpg", "Beth Lemon Dress", 132.69m, "beth-lemon-dress" },
                    { 4, 1, "Navy & White Stripe Pure Linen Slim Shirt – Button Down Collar", "StripyShirt1.jpg", "Navy & White Stripe Shirt", 75.32m, "stripe-shirt" },
                    { 5, 2, "Pink Strappy Volume-Hem Midi Dress", "PinkDress1.jpg", "Parina Pink Dress", 110.89m, "parina-pink-dress" },
                    { 6, 1, "Crafted from 100% cotton sateen and cut for a tailored fit. With a classic cutaway collar, mitred cuffs, and a slight sheen from the lustrous fabric, these are the ultimate statement shirts. This shirt features accents of our Name Of The Rose Print.", "RedShirt1.jpg", "Burgundy Sateen Shirt", 106.14m, "burgundy-sateen-shirt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
