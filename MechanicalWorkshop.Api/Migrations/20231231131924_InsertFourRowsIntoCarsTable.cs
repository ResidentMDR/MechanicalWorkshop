using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MechanicalWorkshop.Api.Migrations
{
    /// <inheritdoc />
    public partial class InsertFourRowsIntoCarsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "VIN", "BrandName", "ModelName", "CustomerId" },
                values: new object[] { 2, "2XYZ456", "Honda", "Accord", 54 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "VIN", "BrandName", "ModelName", "CustomerId" },
                values: new object[] { 3, "3LMN789", "Audi", "A6", 55 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "VIN", "BrandName", "ModelName", "CustomerId" },
                values: new object[] { 4, "2XYZ456", "Mercedes", "CLA", 56 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "VIN", "BrandName", "ModelName", "CustomerId" },
                values: new object[] { 5, "2XYZ456", "Ford", "Focus", 60 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
