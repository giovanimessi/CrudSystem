using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudSystem.Migrations
{
    public partial class InitialCargo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NOME",
                table: "Departamento",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Cargo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CODIGO = table.Column<int>(type: "int", nullable: false),
                    deprtamentoCODIGO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.CargoId);
                    table.ForeignKey(
                        name: "FK_Cargo_Departamento_deprtamentoCODIGO",
                        column: x => x.deprtamentoCODIGO,
                        principalTable: "Departamento",
                        principalColumn: "CODIGO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_deprtamentoCODIGO",
                table: "Cargo",
                column: "deprtamentoCODIGO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.AlterColumn<string>(
                name: "NOME",
                table: "Departamento",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
