using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Closet.API.Migrations
{
    /// <inheritdoc />
    public partial class CarrinhoCompras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarrinhoCompraModelId",
                table: "Roupas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CarrinhoCompras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuantidadeCarrinho = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusPedido = table.Column<string>(type: "TEXT", nullable: false),
                    ValorFinal = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoCompras", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roupas_CarrinhoCompraModelId",
                table: "Roupas",
                column: "CarrinhoCompraModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roupas_CarrinhoCompras_CarrinhoCompraModelId",
                table: "Roupas",
                column: "CarrinhoCompraModelId",
                principalTable: "CarrinhoCompras",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roupas_CarrinhoCompras_CarrinhoCompraModelId",
                table: "Roupas");

            migrationBuilder.DropTable(
                name: "CarrinhoCompras");

            migrationBuilder.DropIndex(
                name: "IX_Roupas_CarrinhoCompraModelId",
                table: "Roupas");

            migrationBuilder.DropColumn(
                name: "CarrinhoCompraModelId",
                table: "Roupas");
        }
    }
}
