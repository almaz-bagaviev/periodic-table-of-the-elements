using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeriodicTable.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActinidesTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtomicNumber = table.Column<int>(type: "int", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageAtomicMass = table.Column<string>(type: "nvarchar(8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActinidesTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChemicalElementsTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtomicNumber = table.Column<int>(type: "int", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageAtomicMass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChemicalElementsTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LanthanidesTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtomicNumber = table.Column<int>(type: "int", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageAtomicMass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanthanidesTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinksTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtomicNumber = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinksTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActinidesTable");

            migrationBuilder.DropTable(
                name: "ChemicalElementsTable");

            migrationBuilder.DropTable(
                name: "LanthanidesTable");

            migrationBuilder.DropTable(
                name: "LinksTable");
        }
    }
}
