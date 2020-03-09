using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storage.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crust_Pizza_PizzaId",
                table: "Crust");

            migrationBuilder.DropForeignKey(
                name: "FK_Size_Pizza_PizzaId",
                table: "Size");

            migrationBuilder.DropForeignKey(
                name: "FK_Topping_Pizza_PizzaId",
                table: "Topping");

            migrationBuilder.DropIndex(
                name: "IX_Size_PizzaId",
                table: "Size");

            migrationBuilder.DropIndex(
                name: "IX_Crust_PizzaId",
                table: "Crust");

            migrationBuilder.AlterColumn<long>(
                name: "PizzaId",
                table: "Topping",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "PizzaId",
                table: "Size",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "CrustId",
                table: "Pizza",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SizeId",
                table: "Pizza",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ToppingId",
                table: "Pizza",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PizzaId",
                table: "Crust",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "Crust",
                columns: new[] { "CrustId", "Name", "PizzaId", "Price" },
                values: new object[,]
                {
                    { 1L, "Deep Dish", null, 3.50m },
                    { 2L, "New York Style", null, 2.50m },
                    { 3L, "Thin Crust", null, 1.50m }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "SizeId", "Name", "PizzaId", "Price" },
                values: new object[,]
                {
                    { 1L, "Large", null, 12.00m },
                    { 2L, "Medium", null, 10.00m },
                    { 3L, "Small", null, 8.00m }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "ToppingId", "Name", "PizzaId", "Price" },
                values: new object[,]
                {
                    { 1L, "Cheese", null, 0.25m },
                    { 2L, "Pepperoni", null, 0.50m },
                    { 3L, "Tomato Sauce", null, 0.75m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Size_PizzaId",
                table: "Size",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_CrustId",
                table: "Pizza",
                column: "CrustId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_SizeId",
                table: "Pizza",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_ToppingId",
                table: "Pizza",
                column: "ToppingId");

            migrationBuilder.CreateIndex(
                name: "IX_Crust_PizzaId",
                table: "Crust",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crust_Pizza_PizzaId",
                table: "Crust",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "PizzaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Crust_CrustId",
                table: "Pizza",
                column: "CrustId",
                principalTable: "Crust",
                principalColumn: "CrustId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Size_SizeId",
                table: "Pizza",
                column: "SizeId",
                principalTable: "Size",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Topping_ToppingId",
                table: "Pizza",
                column: "ToppingId",
                principalTable: "Topping",
                principalColumn: "ToppingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Size_Pizza_PizzaId",
                table: "Size",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "PizzaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topping_Pizza_PizzaId",
                table: "Topping",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "PizzaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crust_Pizza_PizzaId",
                table: "Crust");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Crust_CrustId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Size_SizeId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Topping_ToppingId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Size_Pizza_PizzaId",
                table: "Size");

            migrationBuilder.DropForeignKey(
                name: "FK_Topping_Pizza_PizzaId",
                table: "Topping");

            migrationBuilder.DropIndex(
                name: "IX_Size_PizzaId",
                table: "Size");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_CrustId",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_SizeId",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_ToppingId",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Crust_PizzaId",
                table: "Crust");

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "CrustId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "SizeId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "ToppingId",
                keyValue: 3L);

            migrationBuilder.DropColumn(
                name: "CrustId",
                table: "Pizza");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Pizza");

            migrationBuilder.DropColumn(
                name: "ToppingId",
                table: "Pizza");

            migrationBuilder.AlterColumn<long>(
                name: "PizzaId",
                table: "Topping",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PizzaId",
                table: "Size",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PizzaId",
                table: "Crust",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Size_PizzaId",
                table: "Size",
                column: "PizzaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Crust_PizzaId",
                table: "Crust",
                column: "PizzaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Crust_Pizza_PizzaId",
                table: "Crust",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "PizzaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Size_Pizza_PizzaId",
                table: "Size",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "PizzaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Topping_Pizza_PizzaId",
                table: "Topping",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "PizzaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
