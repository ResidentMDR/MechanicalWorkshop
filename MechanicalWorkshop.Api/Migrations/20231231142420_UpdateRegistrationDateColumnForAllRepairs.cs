using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MechanicalWorkshop.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRegistrationDateColumnForAllRepairs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Repairs SET RegistrationDate = '2023/05/15' WHERE Id = 1;");
            migrationBuilder.Sql("UPDATE Repairs SET RegistrationDate = '2023/07/28' WHERE Id = 2;");
            migrationBuilder.Sql("UPDATE Repairs SET RegistrationDate = '2023/10/10' WHERE Id = 3;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
