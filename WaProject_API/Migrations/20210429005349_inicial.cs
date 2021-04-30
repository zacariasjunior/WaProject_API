using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace WaProject_API.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DataDeCriacao = table.Column<DateTime>(nullable: false),
                    DataDaEntregaRealizada = table.Column<DateTime>(nullable: false),
                    EnderecoEntregaRealizada = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    PedidoId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(maxLength: 120, nullable: false),
                    Descricao = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipe_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    PedidoId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(maxLength: 120, nullable: false),
                    Descricao = table.Column<string>(maxLength: 255, nullable: false),
                    Valor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pedido",
                columns: new[] { "Id", "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 30, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(1522), new DateTime(2021, 4, 28, 21, 53, 48, 623, DateTimeKind.Local).AddTicks(9), "Rua 2, Numero 133, Sao Paulo" },
                    { 2, new DateTime(2021, 4, 30, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4477), new DateTime(2021, 4, 29, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4429), "Rua 18, Numero 135, Sao Paulo" },
                    { 3, new DateTime(2021, 5, 1, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4537), new DateTime(2021, 4, 30, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4534), "Rua 13, Numero 154, Sao Paulo" },
                    { 4, new DateTime(2021, 5, 2, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4550), new DateTime(2021, 5, 1, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4548), "Rua 6, Numero 152, Sao Paulo" },
                    { 5, new DateTime(2021, 5, 3, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4560), new DateTime(2021, 5, 2, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4558), "Rua 7, Numero 148, Sao Paulo" },
                    { 6, new DateTime(2021, 5, 4, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4569), new DateTime(2021, 5, 3, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4567), "Rua 3, Numero 148, Sao Paulo" },
                    { 7, new DateTime(2021, 5, 5, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(5001), new DateTime(2021, 5, 4, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4994), "Rua 14, Numero 71, Sao Paulo" },
                    { 8, new DateTime(2021, 5, 6, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(5013), new DateTime(2021, 5, 5, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(5011), "Rua 1, Numero 186, Sao Paulo" },
                    { 9, new DateTime(2021, 5, 7, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(5022), new DateTime(2021, 5, 6, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(5021), "Rua 6, Numero 107, Sao Paulo" },
                    { 10, new DateTime(2021, 5, 8, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(5031), new DateTime(2021, 5, 7, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(5030), "Rua 3, Numero 160, Sao Paulo" }
                });

            migrationBuilder.InsertData(
                table: "Equipe",
                columns: new[] { "Id", "Descricao", "Nome", "PedidoId" },
                values: new object[,]
                {
                    { 1, "Equipe Cod - 6801 atendimento especial", "Equipe Setor - 42", 1 },
                    { 10, "Equipe Cod - 7993 atendimento especial", "Equipe Setor - 48", 10 },
                    { 2, "Equipe Cod - 7638 atendimento especial", "Equipe Setor - 47", 2 },
                    { 9, "Equipe Cod - 4101 atendimento especial", "Equipe Setor - 46", 9 },
                    { 3, "Equipe Cod - 5520 atendimento especial", "Equipe Setor - 42", 3 },
                    { 8, "Equipe Cod - 4120 atendimento especial", "Equipe Setor - 43", 8 },
                    { 4, "Equipe Cod - 3742 atendimento especial", "Equipe Setor - 45", 4 },
                    { 5, "Equipe Cod - 6294 atendimento especial", "Equipe Setor - 45", 5 },
                    { 7, "Equipe Cod - 2867 atendimento especial", "Equipe Setor - 49", 7 },
                    { 6, "Equipe Cod - 4494 atendimento especial", "Equipe Setor - 41", 6 }
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "Nome", "PedidoId", "Valor" },
                values: new object[,]
                {
                    { 17, "Tv LED Cod - 8907 Samsung", "Tv LED Cod - 48", 9, 1514m },
                    { 16, "Tv LED Cod - 5256 Samsung", "Tv LED Cod - 44", 8, 1741m },
                    { 15, "Tv LED Cod - 4785 Samsung", "Tv LED Cod - 48", 7, 1549m },
                    { 14, "Tv LED Cod - 6153 Samsung", "Tv LED Cod - 49", 7, 1292m },
                    { 13, "Tv LED Cod - 6244 Samsung", "Tv LED Cod - 43", 7, 1911m },
                    { 12, "Tv LED Cod - 2121 Samsung", "Tv LED Cod - 42", 6, 1045m },
                    { 10, "Tv LED Cod - 7440 Samsung", "Tv LED Cod - 45", 5, 1737m },
                    { 18, "Tv LED Cod - 8583 Samsung", "Tv LED Cod - 45", 10, 1651m },
                    { 9, "Tv LED Cod - 7509 Samsung", "Tv LED Cod - 45", 5, 1744m },
                    { 8, "Tv LED Cod - 3136 Samsung", "Tv LED Cod - 40", 4, 1710m },
                    { 7, "Tv LED Cod - 3089 Samsung", "Tv LED Cod - 43", 4, 1120m },
                    { 6, "Tv LED Cod - 7515 Samsung", "Tv LED Cod - 43", 3, 1107m },
                    { 5, "Tv LED Cod - 3195 Samsung", "Tv LED Cod - 48", 3, 1239m },
                    { 4, "Tv LED Cod - 2446 Samsung", "Tv LED Cod - 41", 2, 1692m },
                    { 3, "Tv LED Cod - 3978 Samsung", "Tv LED Cod - 49", 2, 1376m },
                    { 2, "Tv LED Cod - 8254 Samsung", "Tv LED Cod - 41", 1, 1245m },
                    { 1, "Tv LED Cod - 3279 Samsung", "Tv LED Cod - 47", 1, 1345m },
                    { 11, "Tv LED Cod - 8847 Samsung", "Tv LED Cod - 42", 6, 1573m },
                    { 19, "Tv LED Cod - 6602 Samsung", "Tv LED Cod - 47", 10, 1020m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipe_PedidoId",
                table: "Equipe",
                column: "PedidoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_PedidoId",
                table: "Produto",
                column: "PedidoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipe");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Pedido");
        }
    }
}
