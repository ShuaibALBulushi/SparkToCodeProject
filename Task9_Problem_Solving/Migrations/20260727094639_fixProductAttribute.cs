using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task9_Problem_Solving.Migrations
{
    /// <inheritdoc />
    public partial class fixProductAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublicName",
                table: "products",
                newName: "ProductName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "products",
                newName: "PublicName");
        }
    }
}
