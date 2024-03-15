using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudCadastro.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: false),
                    Ativo = table.Column<bool>(type: "BIT", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true),
                    DataValidade = table.Column<DateTime>(type: "DATE", maxLength: 20, nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Idcategoria = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: false),
                    Ativo = table.Column<bool>(type: "BIT", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categoria_Produto",
                        column: x => x.Idcategoria,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Idcategoria",
                table: "Produto",
                column: "Idcategoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
