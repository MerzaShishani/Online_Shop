﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Shop.Migrations
{
    public partial class UserAndDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Vegetables", "Fresh delicious Tomato.", "https://img.freepik.com/free-photo/fresh-red-tomatoes_2829-13449.jpg?w=826&t=st=1675614718~exp=1675615318~hmac=c2bdc29fdcea351ff75bacfbc917a168e497461ec1804ddd2d0fde8178eac8c1", "Tomato", 0.40000000000000002 },
                    { 2, "Vegetables", "Fresh Potato.", "https://img.freepik.com/free-photo/rustic-unpeeled-potatoes-table_144627-3925.jpg?w=1060&t=st=1675614905~exp=1675615505~hmac=793f3a2c1cb7e5ac89ce5ac5f2607d604bf826b21912fb0bff8a723f535386a9", "Potato", 0.69999999999999996 },
                    { 3, "Bakery", "Daily baked Bread.", "https://img.freepik.com/free-photo/homemade-crunchy-bread-with-grains_144627-362.jpg?w=900&t=st=1675615019~exp=1675615619~hmac=b53b74310754008c820d261d82db8c728e95b135fc8afedd5a0f27f3d3e94446", "Bread", 0.5 },
                    { 4, "Bakery", "Daily baked Cake.", "https://img.freepik.com/free-photo/dessert-fruitcake_144627-10487.jpg?w=1060&t=st=1675615714~exp=1675616314~hmac=874ceff2453cf3a9f6afe33ee1b2b342dd192fa400992b2da92e696be60e87b3", "Cake", 4.0 },
                    { 5, "Fruits", "Fresh orange", "https://img.freepik.com/free-photo/cut-whole-orange-fruits-with-green-leaves_74855-5380.jpg?w=1060&t=st=1675615765~exp=1675616365~hmac=5041a96046676f57f07495bd30c0da3ed08fbc7cb862c508f3b7103b845f472a", "Orange", 1.5 },
                    { 6, "Fruits", "Fresh Apple", "https://img.freepik.com/free-photo/apples-red-fresh-mellow-juicy-perfect-whole-white-desk_179666-271.jpg?w=1060&t=st=1675615812~exp=1675616412~hmac=9f78977f6265c61c89386c6ab4fb3b4acbe3d58e84c1d2414f2f7ba0db05a81f", "Apple", 1.2 },
                    { 7, "Fruits", "Fresh Strawberry", "https://img.freepik.com/free-photo/red-fresh-strawberries-with-green-leaves_114579-10506.jpg?w=1060&t=st=1675615838~exp=1675616438~hmac=819b621145b32e08c8de8361c9d988c96d3a7f108c9e7da615e0974038850cdb", "Strawberry", 1.1000000000000001 },
                    { 8, "Clothes", "White Shirt.", "https://img.freepik.com/free-photo/white-t-shirts-with-copy-space-gray-background_53876-104920.jpg?w=1060&t=st=1675615107~exp=1675615707~hmac=6ec76c9f8f3efee7e124f69cfbf50a8686b77add425996311727cf9ee3c4dac3", "White Shirt", 15.0 },
                    { 9, "Clothes", "Pink Sneaker.", "https://img.freepik.com/free-photo/sport-running-shoes_1203-3414.jpg?w=1060&t=st=1675615218~exp=1675615818~hmac=1cae061fb4dce8f73da4f955ef38f2548634c40e2adfdf04dceb58006e5c9999", "Pink Sneakers", 50.0 },
                    { 10, "Clothes", "Men Sneakers", "https://img.freepik.com/free-photo/fashion-shoes-sneakers_1203-7528.jpg?w=1060&t=st=1675615295~exp=1675615895~hmac=df919a47aa54af4a9249f77540bd9c7b88c303651434dd039dd25fafdcdc0cc1", "Men Sneakers", 60.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "admin@example.com", true, "admin", "admin" },
                    { 2, "user@example.com", false, "user", "user" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");
        }
    }
}
