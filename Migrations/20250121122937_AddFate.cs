using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cadastro.Migrations
{
    /// <inheritdoc />
    public partial class AddFate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fate",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fate",
                table: "User");
        }
    }
}
