using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace USAPrimeAPI.Migrations
{
    public partial class softball : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "No_of_Softball_Teams",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "No_of_Softball_Teams",
                table: "AspNetUsers");
        }
    }
}
