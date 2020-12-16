namespace EntityFrameworkExamples.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class RemoveZucchini : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder) =>
            migrationBuilder.AddColumn<string>("Zucchini", "FruitBaskets", "nvarchar(max)", nullable: true);

        protected override void Up(MigrationBuilder migrationBuilder) =>
            migrationBuilder.DropColumn("Zucchini", "FruitBaskets");
    }
}
