using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online2.DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Calorie = table.Column<double>(type: "float(4)", precision: 4, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MealFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Portion = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealFoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MealFoods_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MealFoods_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreateOn", "UpdateOn", "isActive" },
                values: new object[,]
                {
                    { 1, "Süt Grubu", new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4004), null, true },
                    { 2, "Et Grubu", new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4011), null, true },
                    { 3, "KuruBaklagil Grubu", new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4013), null, true },
                    { 4, "Ekmek Grubu", new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4015), null, true },
                    { 5, "Sebze Grubu", new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4017), null, true },
                    { 6, "Meyve Grubu", new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4019), null, true },
                    { 7, "Yağ Grubu", new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4021), null, true },
                    { 8, "Tatlı Grubu", new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4024), null, true },
                    { 9, "Kuruyemiş Grubu", new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4026), null, true }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CreateOn", "MealName", "UpdateOn", "isActive" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(145), "Kahvaltı", null, true },
                    { 2, new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(152), "Öğle Yemeği", null, true },
                    { 3, new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(154), "Akşam Yemeği", null, true }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateOn", "Email", "Password", "UpdateOn", "UserName", "UserTypes", "isActive" },
                values: new object[] { 1, new DateTime(2022, 12, 20, 23, 27, 6, 957, DateTimeKind.Local).AddTicks(5496), "admin@gmail.com", "123456", null, "Admin", "Admin", true });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calorie", "CategoryId", "CreateOn", "Description", "FoodName", "UpdateOn", "isActive" },
                values: new object[,]
                {
                    { 1, 11400.0, 1, new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9127), "1 su bardağı,200 ml", "Süt", null, true },
                    { 2, 69000.0, 2, new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9136), "1 köfte, 30gr", "Kıyma", null, true },
                    { 3, 80000.0, 3, new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9138), "4 yemek kaşığı, 25gr", "Mercimek", null, true },
                    { 4, 68000.0, 4, new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9141), "3 yemek kaşığı, 50gr", "Makarna", null, true },
                    { 5, 25000.0, 5, new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9143), "4 yemek kaşığı, 200gr", "Brokoli(Pişmiş)", null, true },
                    { 6, 60000.0, 6, new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9145), "1 küçük boy, 120gr", "Elma", null, true },
                    { 7, 45000.0, 7, new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9148), "1 tatlı kaşığı, 5gr", "Tereyağ", null, true },
                    { 8, 68000.0, 8, new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9150), "1 yemek kaşığı, 30gr", "Bal", null, true },
                    { 9, 45000.0, 9, new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9152), "2 adet, 8gr", "Ceviz içi", null, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodName",
                table: "Foods",
                column: "FoodName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MealFoods_FoodId",
                table: "MealFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_MealFoods_MealId",
                table: "MealFoods",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_MealFoods_UserId",
                table: "MealFoods",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_MealName",
                table: "Meals",
                column: "MealName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealFoods");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
