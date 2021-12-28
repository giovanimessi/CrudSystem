using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudSystem.Migrations
{
    public partial class LigacaoCargo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departamentoCODIGO",
                table: "Cargo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_departamentoCODIGO",
                table: "Cargo",
                column: "departamentoCODIGO");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargo_Departamento_departamentoCODIGO",
                table: "Cargo",
                column: "departamentoCODIGO",
                principalTable: "Departamento",
                principalColumn: "CODIGO",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargo_Departamento_departamentoCODIGO",
                table: "Cargo");

            migrationBuilder.DropIndex(
                name: "IX_Cargo_departamentoCODIGO",
                table: "Cargo");

            migrationBuilder.DropColumn(
                name: "departamentoCODIGO",
                table: "Cargo");
        }
    }
}
