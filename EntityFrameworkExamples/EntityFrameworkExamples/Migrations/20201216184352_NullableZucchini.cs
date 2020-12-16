namespace EntityFrameworkExamples.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class NullableZucchini : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder) =>
            migrationBuilder.AlterColumn<string>(
                "Zucchini",
                "FruitBaskets",
                "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

        protected override void Up(MigrationBuilder migrationBuilder) =>
            migrationBuilder.AlterColumn<string>(
                "Zucchini",
                "FruitBaskets",
                "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
    }
}
