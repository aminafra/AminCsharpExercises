using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Data.MIgrations
{
    public partial class AddedTruePass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PassWordSalt",
                table: "Users",
                newName: "PasswordSalt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordSalt",
                table: "Users",
                newName: "PassWordSalt");
        }
    }
}
