using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Closet.API.Migrations
{
    /// <inheritdoc />
    public partial class Atualizandocarrinhodecompras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusPedido",
                table: "CarrinhoCompras");

            migrationBuilder.DropColumn(
                name: "ValorFinal",
                table: "CarrinhoCompras");

            migrationBuilder.AddColumn<bool>(
                name: "Comprou",
                table: "CarrinhoCompras",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comprou",
                table: "CarrinhoCompras");

            migrationBuilder.AddColumn<string>(
                name: "StatusPedido",
                table: "CarrinhoCompras",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "ValorFinal",
                table: "CarrinhoCompras",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
