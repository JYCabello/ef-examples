using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkExamples.Migrations
{
    public partial class BasketMakers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasketMakers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketMakers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BasketMakerFruitBasket",
                columns: table => new
                {
                    BasketMakersID = table.Column<int>(type: "int", nullable: false),
                    FruitBasketsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketMakerFruitBasket", x => new { x.BasketMakersID, x.FruitBasketsID });
                    table.ForeignKey(
                        name: "FK_BasketMakerFruitBasket_BasketMakers_BasketMakersID",
                        column: x => x.BasketMakersID,
                        principalTable: "BasketMakers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketMakerFruitBasket_FruitBaskets_FruitBasketsID",
                        column: x => x.FruitBasketsID,
                        principalTable: "FruitBaskets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketMakerFruitBasket_FruitBasketsID",
                table: "BasketMakerFruitBasket",
                column: "FruitBasketsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketMakerFruitBasket");

            migrationBuilder.DropTable(
                name: "BasketMakers");
        }
    }
}
