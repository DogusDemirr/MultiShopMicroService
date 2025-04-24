using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultiShop.Cargo.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCargoCompanyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CargoCompanyName",
                table: "CargoCompanies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CargoCompanyName",
                table: "CargoCompanies",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
