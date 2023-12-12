using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Closet.API.Migrations
{
    /// <inheritdoc />
    public partial class Atualizandocategorias4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaModelRoupaModel");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Roupas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roupas_CategoriaId",
                table: "Roupas",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roupas_Categorias_CategoriaId",
                table: "Roupas",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roupas_Categorias_CategoriaId",
                table: "Roupas");

            migrationBuilder.DropIndex(
                name: "IX_Roupas_CategoriaId",
                table: "Roupas");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Roupas");

            migrationBuilder.CreateTable(
                name: "CategoriaModelRoupaModel",
                columns: table => new
                {
                    CategoriasId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoupasId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaModelRoupaModel", x => new { x.CategoriasId, x.RoupasId });
                    table.ForeignKey(
                        name: "FK_CategoriaModelRoupaModel_Categorias_CategoriasId",
                        column: x => x.CategoriasId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaModelRoupaModel_Roupas_RoupasId",
                        column: x => x.RoupasId,
                        principalTable: "Roupas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaModelRoupaModel_RoupasId",
                table: "CategoriaModelRoupaModel",
                column: "RoupasId");
        }
    }
}
