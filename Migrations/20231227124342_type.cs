using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DouVoitOn.Migrations
{
    /// <inheritdoc />
    public partial class type : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "typePanneauId",
                table: "LieuPanneau",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LieuPanneau_typePanneauId",
                table: "LieuPanneau",
                column: "typePanneauId");

            migrationBuilder.AddForeignKey(
                name: "FK_LieuPanneau_TypesPanneau_typePanneauId",
                table: "LieuPanneau",
                column: "typePanneauId",
                principalTable: "TypesPanneau",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LieuPanneau_TypesPanneau_typePanneauId",
                table: "LieuPanneau");

            migrationBuilder.DropIndex(
                name: "IX_LieuPanneau_typePanneauId",
                table: "LieuPanneau");

            migrationBuilder.DropColumn(
                name: "typePanneauId",
                table: "LieuPanneau");
        }
    }
}
