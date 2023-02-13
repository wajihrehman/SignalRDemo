using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace USAPrimeAPI.Migrations
{
    public partial class AgreemtContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AgreementContent",
                table: "onePagerMaster",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgreementContent",
                table: "onePagerMaster");
        }
    }
}
