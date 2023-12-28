using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DouVoitOn.Migrations
{
    /// <inheritdoc />
    public partial class activ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "distance",
                table: "LieuPanneau",
                newName: "Distance");

            migrationBuilder.AddColumn<bool>(
                name: "Activated",
                table: "Panneaux",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activated",
                table: "Panneaux");

            migrationBuilder.RenameColumn(
                name: "Distance",
                table: "LieuPanneau",
                newName: "distance");
        }
    }
}
