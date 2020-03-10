using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PizzaTopping",
                columns: new[] { "PizzaId", "ToppingId" },
                values: new object[] { 1L, 1L });

            migrationBuilder.InsertData(
                table: "PizzaTopping",
                columns: new[] { "PizzaId", "ToppingId" },
                values: new object[] { 2L, 1L });

            migrationBuilder.InsertData(
                table: "PizzaTopping",
                columns: new[] { "PizzaId", "ToppingId" },
                values: new object[] { 3L, 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PizzaTopping",
                keyColumns: new[] { "PizzaId", "ToppingId" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "PizzaTopping",
                keyColumns: new[] { "PizzaId", "ToppingId" },
                keyValues: new object[] { 2L, 1L });

            migrationBuilder.DeleteData(
                table: "PizzaTopping",
                keyColumns: new[] { "PizzaId", "ToppingId" },
                keyValues: new object[] { 3L, 1L });
        }
    }
}
