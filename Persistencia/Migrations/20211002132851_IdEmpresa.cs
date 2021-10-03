using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class IdEmpresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fechaDeNacimiento",
                table: "Personas",
                newName: "FechaDeNacimiento");

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Salario",
                table: "Personas",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cliente_IdEmpresa",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "Personas",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Cliente_IdEmpresa",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "FechaDeNacimiento",
                table: "Personas",
                newName: "fechaDeNacimiento");

            migrationBuilder.AlterColumn<int>(
                name: "Salario",
                table: "Personas",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }
    }
}
