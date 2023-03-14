using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeitorNfe.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinatarios",
                columns: table => new
                {
                    IDDestinatario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDEndereco = table.Column<int>(type: "int", nullable: false),
                    cnpj = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinatarios", x => x.IDDestinatario);
                });

            migrationBuilder.CreateTable(
                name: "Emitentes",
                columns: table => new
                {
                    IDEmitente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDEndereco = table.Column<int>(type: "int", nullable: false),
                    cnpj = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emitentes", x => x.IDEmitente);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    IDEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logadouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numero = table.Column<int>(type: "int", nullable: false),
                    bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    municipio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cep = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.IDEndereco);
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    IDNota = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nNota = table.Column<int>(type: "int", nullable: false),
                    dEmissao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDEmitente = table.Column<int>(type: "int", nullable: false),
                    IDDestinatario = table.Column<int>(type: "int", nullable: false),
                    nPedidoCompra = table.Column<int>(type: "int", nullable: false),
                    IDProduto = table.Column<int>(type: "int", nullable: false),
                    cAcesso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    comentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    totalNota = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.IDNota);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    IDProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nItem = table.Column<int>(type: "int", nullable: false),
                    cProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qtdProduto = table.Column<int>(type: "int", nullable: false),
                    vUnitario = table.Column<int>(type: "int", nullable: false),
                    vTotalProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.IDProduto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinatarios");

            migrationBuilder.DropTable(
                name: "Emitentes");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
