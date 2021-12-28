using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudSystem.Migrations
{
    public partial class InitialCargo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargo_Departamento_deprtamentoCODIGO",
                table: "Cargo");

            migrationBuilder.DropIndex(
                name: "IX_Cargo_deprtamentoCODIGO",
                table: "Cargo");

            migrationBuilder.DropColumn(
                name: "CODIGO",
                table: "Cargo");

            migrationBuilder.DropColumn(
                name: "deprtamentoCODIGO",
                table: "Cargo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CODIGO",
                table: "Cargo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "deprtamentoCODIGO",
                table: "Cargo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_deprtamentoCODIGO",
                table: "Cargo",
                column: "deprtamentoCODIGO");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargo_Departamento_deprtamentoCODIGO",
                table: "Cargo",
                column: "deprtamentoCODIGO",
                principalTable: "Departamento",
                principalColumn: "CODIGO",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
