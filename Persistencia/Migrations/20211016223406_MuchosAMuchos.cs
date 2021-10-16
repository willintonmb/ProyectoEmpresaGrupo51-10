using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class MuchosAMuchos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Empresas_IdEmpresa",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_IdEmpresa",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Productos");

            migrationBuilder.CreateTable(
                name: "ProductoEmpresa",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoEmpresa", x => new { x.IdProducto, x.IdEmpresa });
                    table.ForeignKey(
                        name: "FK_ProductoEmpresa_Empresas_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoEmpresa_Productos_IdProducto",
                        column: x => x.IdProducto,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoEmpresa_IdEmpresa",
                table: "ProductoEmpresa",
                column: "IdEmpresa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoEmpresa");

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdEmpresa",
                table: "Productos",
                column: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Empresas_IdEmpresa",
                table: "Productos",
                column: "IdEmpresa",
                principalTable: "Empresas",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
