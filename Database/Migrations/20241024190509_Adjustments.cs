using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class Adjustments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Atencion",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Proyecto",
                table: "Clientes");

            migrationBuilder.AddColumn<string>(
                name: "Atencion",
                table: "Facturas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Proyecto",
                table: "Facturas",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Atencion",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "Proyecto",
                table: "Facturas");

            migrationBuilder.AddColumn<string>(
                name: "Atencion",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Proyecto",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
