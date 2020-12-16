namespace EntityFrameworkExamples.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class InitialCreation : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder) =>
            migrationBuilder.DropTable("FruitBaskets");

        protected override void Up(MigrationBuilder migrationBuilder) =>
            migrationBuilder.CreateTable(
                "FruitBaskets",
                table => new
                {
                    ID = table.Column<int>("int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Banana = table.Column<string>("nvarchar(max)", nullable: false),
                    Pear = table.Column<string>("nvarchar(max)", nullable: false),
                    Zucchini = table.Column<string>("nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FruitBaskets", x => x.ID);
                });
    }
}
