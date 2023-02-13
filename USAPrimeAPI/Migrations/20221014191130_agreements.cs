using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace USAPrimeAPI.Migrations
{
    public partial class agreements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Agreements",
                columns: table => new
                {
                    Form_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterID = table.Column<int>(type: "int", nullable: true),
                    Season_ID = table.Column<int>(type: "int", nullable: false),
                    User_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Player_Fee = table.Column<double>(type: "float", nullable: true),
                    Uniform_Fee = table.Column<double>(type: "float", nullable: true),
                    No_Of_Full_Paid_Players_Per_Team = table.Column<int>(type: "int", nullable: true),
                    Tournament_Budget_Per_Team = table.Column<int>(type: "int", nullable: true),
                    Coach_Pay_Per_team = table.Column<double>(type: "float", nullable: true),
                    Indoor_Rental = table.Column<double>(type: "float", nullable: true),
                    Outdoor_Rental = table.Column<double>(type: "float", nullable: true),
                    Additional_Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    forwardedToAdmin = table.Column<bool>(type: "bit", nullable: false),
                    approvedByAdmin = table.Column<bool>(type: "bit", nullable: true),
                    agreement = table.Column<bool>(type: "bit", nullable: true),
                    TrxDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Agreements", x => x.Form_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Agreements");
        }
    }
}
