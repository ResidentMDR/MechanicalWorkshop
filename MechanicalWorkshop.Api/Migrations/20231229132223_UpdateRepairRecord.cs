using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MechanicalWorkshop.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRepairRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "Repairs",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "Repairs");
        }
    }
}
