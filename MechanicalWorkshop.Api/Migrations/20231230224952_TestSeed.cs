using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MechanicalWorkshop.Api.Migrations
{
    /// <inheritdoc />
    public partial class TestSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "VIN", "BrandName", "ModelName", "CustomerId" },
                values: new object[] { 1, "1ABC123", "Toyota", "Camry", 52 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
