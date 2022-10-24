using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeriodicTable.Migrations
{
    public partial class AtomicNumberIsDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "AverageAtomicMass",
                table: "LanthanidesTable",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)");

            migrationBuilder.AlterColumn<double>(
                name: "AverageAtomicMass",
                table: "ChemicalElementsTable",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)");

            migrationBuilder.AlterColumn<double>(
                name: "AverageAtomicMass",
                table: "ActinidesTable",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AverageAtomicMass",
                table: "LanthanidesTable",
                type: "nvarchar(8)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "AverageAtomicMass",
                table: "ChemicalElementsTable",
                type: "nvarchar(8)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "AverageAtomicMass",
                table: "ActinidesTable",
                type: "nvarchar(8)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
