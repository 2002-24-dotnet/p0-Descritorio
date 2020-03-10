using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrustDbSet",
                columns: table => new
                {
                    CrustId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrustDbSet", x => x.CrustId);
                });

            migrationBuilder.CreateTable(
                name: "SizeDbSet",
                columns: table => new
                {
                    SizeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeDbSet", x => x.SizeId);
                });

            migrationBuilder.CreateTable(
                name: "ToppingDbSet",
                columns: table => new
                {
                    ToppingId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToppingDbSet", x => x.ToppingId);
                });

            migrationBuilder.CreateTable(
                name: "PizzaDbSet",
                columns: table => new
                {
                    PizzaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CrustId = table.Column<long>(nullable: true),
                    SizeId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaDbSet", x => x.PizzaId);
                    table.ForeignKey(
                        name: "FK_PizzaDbSet_CrustDbSet_CrustId",
                        column: x => x.CrustId,
                        principalTable: "CrustDbSet",
                        principalColumn: "CrustId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PizzaDbSet_SizeDbSet_SizeId",
                        column: x => x.SizeId,
                        principalTable: "SizeDbSet",
                        principalColumn: "SizeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PizzaTopping",
                columns: table => new
                {
                    PizzaId = table.Column<long>(nullable: false),
                    ToppingId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaTopping", x => new { x.PizzaId, x.ToppingId });
                    table.ForeignKey(
                        name: "FK_PizzaTopping_PizzaDbSet_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "PizzaDbSet",
                        principalColumn: "PizzaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PizzaTopping_ToppingDbSet_ToppingId",
                        column: x => x.ToppingId,
                        principalTable: "ToppingDbSet",
                        principalColumn: "ToppingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CrustDbSet",
                columns: new[] { "CrustId", "Name" },
                values: new object[,]
                {
                    { 1L, "Deep Dish" },
                    { 2L, "New York Style" },
                    { 3L, "Thin Crust" }
                });

            migrationBuilder.InsertData(
                table: "PizzaDbSet",
                columns: new[] { "PizzaId", "CrustId", "Name", "SizeId" },
                values: new object[,]
                {
                    { 1L, null, "The Dominic", null },
                    { 2L, null, "The Fred", null },
                    { 3L, null, "The Enthusiast", null }
                });

            migrationBuilder.InsertData(
                table: "SizeDbSet",
                columns: new[] { "SizeId", "Name" },
                values: new object[,]
                {
                    { 1L, "Large" },
                    { 2L, "Medium" },
                    { 3L, "Small" }
                });

            migrationBuilder.InsertData(
                table: "ToppingDbSet",
                columns: new[] { "ToppingId", "Name" },
                values: new object[,]
                {
                    { 1L, "Cheese" },
                    { 2L, "Pepperoni" },
                    { 3L, "Tomato Sauce" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PizzaDbSet_CrustId",
                table: "PizzaDbSet",
                column: "CrustId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaDbSet_SizeId",
                table: "PizzaDbSet",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaTopping_ToppingId",
                table: "PizzaTopping",
                column: "ToppingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaTopping");

            migrationBuilder.DropTable(
                name: "PizzaDbSet");

            migrationBuilder.DropTable(
                name: "ToppingDbSet");

            migrationBuilder.DropTable(
                name: "CrustDbSet");

            migrationBuilder.DropTable(
                name: "SizeDbSet");
        }
    }
}
