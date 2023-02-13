using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace USAPrimeAPI.Migrations
{
    public partial class master : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Agreement",
                table: "onePagerMaster",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Approve",
                table: "onePagerMaster",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Form_ID",
                table: "onePagerMaster",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Agreement",
                table: "onePagerMaster");

            migrationBuilder.DropColumn(
                name: "Approve",
                table: "onePagerMaster");

            migrationBuilder.DropColumn(
                name: "Form_ID",
                table: "onePagerMaster");
        }
    }
}
