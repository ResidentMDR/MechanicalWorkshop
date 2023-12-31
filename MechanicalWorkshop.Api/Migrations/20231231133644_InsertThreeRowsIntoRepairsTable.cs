using MechanicalWorkshop.Api.Model;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MechanicalWorkshop.Api.Migrations
{
    /// <inheritdoc />
    public partial class InsertThreeRowsIntoRepairsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Repairs",
                columns: new[] { "Id", "CustomerId", "CarId", "Description", "Price", "MechanicId" },
                values: new object[] { 1, "54", "2", "Oil leak", 2800, 1 });

            migrationBuilder.InsertData(
                table: "Repairs",
                columns: new[] { "Id", "CustomerId", "CarId", "Description", "Price", "MechanicId" },
                values: new object[] { 2, "55", "3", "Brake Pads are noisy", 800, 2 });

            migrationBuilder.InsertData(
                table: "Repairs",
                columns: new[] { "Id", "CustomerId", "CarId", "Description", "Price", "MechanicId" },
                values: new object[] { 3, "60", "5", "General overview", 200, 3 });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
