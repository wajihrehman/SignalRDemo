using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace USAPrimeAPI.Migrations
{
    public partial class formulss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Baseballs",
                table: "onePagerAdmin",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Catch",
                table: "onePagerAdmin",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CoachesGear",
                table: "onePagerAdmin",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Insurance",
                table: "onePagerAdmin",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "NationalFundraiser",
                table: "onePagerAdmin",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "USAPrimeApp",
                table: "onePagerAdmin",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UniformExpense",
                table: "onePagerAdmin",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Baseballs",
                table: "onePagerAdmin");

            migrationBuilder.DropColumn(
                name: "Catch",
                table: "onePagerAdmin");

            migrationBuilder.DropColumn(
                name: "CoachesGear",
                table: "onePagerAdmin");

            migrationBuilder.DropColumn(
                name: "Insurance",
                table: "onePagerAdmin");

            migrationBuilder.DropColumn(
                name: "NationalFundraiser",
                table: "onePagerAdmin");

            migrationBuilder.DropColumn(
                name: "USAPrimeApp",
                table: "onePagerAdmin");

            migrationBuilder.DropColumn(
                name: "UniformExpense",
                table: "onePagerAdmin");
        }
    }
}
