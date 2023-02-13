using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace USAPrimeAPI.Migrations
{
    public partial class rmvIndoor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Indoor_Rental",
                table: "T_One_Pager");

            migrationBuilder.DropColumn(
                name: "Outdoor_Rental",
                table: "T_One_Pager");

            migrationBuilder.DropColumn(
                name: "Indoor_Rental",
                table: "onePagerAdmin");

            migrationBuilder.DropColumn(
                name: "Outdoor_Rental",
                table: "onePagerAdmin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Indoor_Rental",
                table: "T_One_Pager",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Outdoor_Rental",
                table: "T_One_Pager",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Indoor_Rental",
                table: "onePagerAdmin",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Outdoor_Rental",
                table: "onePagerAdmin",
                type: "float",
                nullable: true);
        }
    }
}
