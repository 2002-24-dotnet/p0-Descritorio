using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaDbSet_CrustDbSet_CrustId",
                table: "PizzaDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaDbSet_SizeDbSet_SizeId",
                table: "PizzaDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaTopping_PizzaDbSet_PizzaId",
                table: "PizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PizzaDbSet",
                table: "PizzaDbSet");

            migrationBuilder.RenameTable(
                name: "PizzaDbSet",
                newName: "Pizza");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaDbSet_SizeId",
                table: "Pizza",
                newName: "IX_Pizza_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaDbSet_CrustId",
                table: "Pizza",
                newName: "IX_Pizza_CrustId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizza",
                table: "Pizza",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_CrustDbSet_CrustId",
                table: "Pizza",
                column: "CrustId",
                principalTable: "CrustDbSet",
                principalColumn: "CrustId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_SizeDbSet_SizeId",
                table: "Pizza",
                column: "SizeId",
                principalTable: "SizeDbSet",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaTopping_Pizza_PizzaId",
                table: "PizzaTopping",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "PizzaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_CrustDbSet_CrustId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_SizeDbSet_SizeId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaTopping_Pizza_PizzaId",
                table: "PizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizza",
                table: "Pizza");

            migrationBuilder.RenameTable(
                name: "Pizza",
                newName: "PizzaDbSet");

            migrationBuilder.RenameIndex(
                name: "IX_Pizza_SizeId",
                table: "PizzaDbSet",
                newName: "IX_PizzaDbSet_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizza_CrustId",
                table: "PizzaDbSet",
                newName: "IX_PizzaDbSet_CrustId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PizzaDbSet",
                table: "PizzaDbSet",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaDbSet_CrustDbSet_CrustId",
                table: "PizzaDbSet",
                column: "CrustId",
                principalTable: "CrustDbSet",
                principalColumn: "CrustId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaDbSet_SizeDbSet_SizeId",
                table: "PizzaDbSet",
                column: "SizeId",
                principalTable: "SizeDbSet",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaTopping_PizzaDbSet_PizzaId",
                table: "PizzaTopping",
                column: "PizzaId",
                principalTable: "PizzaDbSet",
                principalColumn: "PizzaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
