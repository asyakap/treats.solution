using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Treats.Migrations
{
    public partial class EditTreatModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TreatName",
                table: "Treats",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Treats",
                newName: "TreatName");
        }
    }
}
