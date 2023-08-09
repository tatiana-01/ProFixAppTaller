using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class Correciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Especialidades_EspecialidadId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Sucursales_SucursalId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Reparaciones_ProductoStocks_ProductoStockId",
                table: "Reparaciones");

            migrationBuilder.DropIndex(
                name: "IX_Reparaciones_ProductoStockId",
                table: "Reparaciones");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_EspecialidadId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_SucursalId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "ProductoStockId",
                table: "Reparaciones");

            migrationBuilder.DropColumn(
                name: "EspecialidadId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "SucursalId",
                table: "Empleados");

            migrationBuilder.AddColumn<string>(
                name: "Placa",
                table: "Vehiculos",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Sucursales",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdEspecialidad",
                table: "Empleados",
                column: "IdEspecialidad");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdSucursal",
                table: "Empleados",
                column: "IdSucursal");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Especialidades_IdEspecialidad",
                table: "Empleados",
                column: "IdEspecialidad",
                principalTable: "Especialidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Sucursales_IdSucursal",
                table: "Empleados",
                column: "IdSucursal",
                principalTable: "Sucursales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Especialidades_IdEspecialidad",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Sucursales_IdSucursal",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdEspecialidad",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_IdSucursal",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Placa",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Sucursales");

            migrationBuilder.AddColumn<int>(
                name: "ProductoStockId",
                table: "Reparaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EspecialidadId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SucursalId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reparaciones_ProductoStockId",
                table: "Reparaciones",
                column: "ProductoStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_EspecialidadId",
                table: "Empleados",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_SucursalId",
                table: "Empleados",
                column: "SucursalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Especialidades_EspecialidadId",
                table: "Empleados",
                column: "EspecialidadId",
                principalTable: "Especialidades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Sucursales_SucursalId",
                table: "Empleados",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reparaciones_ProductoStocks_ProductoStockId",
                table: "Reparaciones",
                column: "ProductoStockId",
                principalTable: "ProductoStocks",
                principalColumn: "Id");
        }
    }
}
