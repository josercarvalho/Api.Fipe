using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JC_ViaBrasil.Migrations
{
    /// <inheritdoc />
    public partial class DbInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabelaFipe",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valor = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    marca = table.Column<string>(type: "varchar", nullable: true),
                    modelo = table.Column<string>(type: "varchar", nullable: true),
                    anoModelo = table.Column<int>(type: "integer", nullable: false),
                    combustivel = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    codigoFipe = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    mesReferencia = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    tipoVeiculo = table.Column<int>(type: "integer", maxLength: 5, nullable: false),
                    siglaCombustivel = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: true),
                    dataConsulta = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    placaVeiculo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaFipe", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelaFipe");
        }
    }
}
