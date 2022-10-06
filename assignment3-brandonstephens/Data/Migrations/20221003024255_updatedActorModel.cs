using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment3_brandonstephens.Data.Migrations
{
    public partial class updatedActorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Actor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IMDBLink",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "IMDBLink",
                table: "Actor");
        }
    }
}
