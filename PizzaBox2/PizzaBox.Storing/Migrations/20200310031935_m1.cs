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
                    CrustId = table.Column<long>(nullable: false),
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
                    SizeId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeDbSet", x => x.SizeId);
                });

            migrationBuilder.CreateTable(
                name: "StoreDbSet",
                columns: table => new
                {
                    StoreId = table.Column<long>(nullable: false),
                    StoreAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreDbSet", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "ToppingDbSet",
                columns: table => new
                {
                    ToppingId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToppingDbSet", x => x.ToppingId);
                });

            migrationBuilder.CreateTable(
                name: "UserDbSet",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDbSet", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "OrderDbSet",
                columns: table => new
                {
                    OrderId = table.Column<long>(nullable: false),
                    Date = table.Column<long>(nullable: false),
                    StoreId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDbSet", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_OrderDbSet_StoreDbSet_StoreId",
                        column: x => x.StoreId,
                        principalTable: "StoreDbSet",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDbSet_UserDbSet_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDbSet",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PizzaDbSet",
                columns: table => new
                {
                    PizzaId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CrustId = table.Column<long>(nullable: true),
                    SizeId = table.Column<long>(nullable: true),
                    OrderId = table.Column<long>(nullable: true)
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
                        name: "FK_PizzaDbSet_OrderDbSet_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderDbSet",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PizzaDbSet_SizeDbSet_SizeId",
                        column: x => x.SizeId,
                        principalTable: "SizeDbSet",
                        principalColumn: "SizeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PizzaToppingDbSet",
                columns: table => new
                {
                    PizzaId = table.Column<long>(nullable: false),
                    ToppingId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaToppingDbSet", x => new { x.PizzaId, x.ToppingId });
                    table.ForeignKey(
                        name: "FK_PizzaToppingDbSet_PizzaDbSet_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "PizzaDbSet",
                        principalColumn: "PizzaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PizzaToppingDbSet_ToppingDbSet_ToppingId",
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
                columns: new[] { "PizzaId", "CrustId", "Name", "OrderId", "SizeId" },
                values: new object[,]
                {
                    { 1L, null, "The Dominic", null, null },
                    { 2L, null, "The Fred", null, null },
                    { 3L, null, "The Enthusiast", null, null }
                });

            migrationBuilder.InsertData(
                table: "SizeDbSet",
                columns: new[] { "SizeId", "Name" },
                values: new object[,]
                {
                    { 2L, "Medium" },
                    { 3L, "Small" },
                    { 1L, "Large" }
                });

            migrationBuilder.InsertData(
                table: "StoreDbSet",
                columns: new[] { "StoreId", "StoreAddress" },
                values: new object[,]
                {
                    { 1L, "Street 1" },
                    { 2L, "Street 2" },
                    { 3L, "Street 3" }
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

            migrationBuilder.InsertData(
                table: "UserDbSet",
                columns: new[] { "UserId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2L, "Fred", "Flintstone" },
                    { 1L, "Bob", "Builder" },
                    { 3L, "Cat", "Kansas" }
                });

            migrationBuilder.InsertData(
                table: "OrderDbSet",
                columns: new[] { "OrderId", "Date", "StoreId", "UserId" },
                values: new object[,]
                {
                    { 1L, 637193891747977610L, 3L, 1L },
                    { 2L, 637193891747979310L, 2L, 2L },
                    { 3L, 637193891747979350L, 1L, 3L }
                });

            migrationBuilder.InsertData(
                table: "PizzaToppingDbSet",
                columns: new[] { "PizzaId", "ToppingId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 2L, 1L },
                    { 3L, 1L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDbSet_StoreId",
                table: "OrderDbSet",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDbSet_UserId",
                table: "OrderDbSet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaDbSet_CrustId",
                table: "PizzaDbSet",
                column: "CrustId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaDbSet_OrderId",
                table: "PizzaDbSet",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaDbSet_SizeId",
                table: "PizzaDbSet",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaToppingDbSet_ToppingId",
                table: "PizzaToppingDbSet",
                column: "ToppingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaToppingDbSet");

            migrationBuilder.DropTable(
                name: "PizzaDbSet");

            migrationBuilder.DropTable(
                name: "ToppingDbSet");

            migrationBuilder.DropTable(
                name: "CrustDbSet");

            migrationBuilder.DropTable(
                name: "OrderDbSet");

            migrationBuilder.DropTable(
                name: "SizeDbSet");

            migrationBuilder.DropTable(
                name: "StoreDbSet");

            migrationBuilder.DropTable(
                name: "UserDbSet");
        }
    }
}
