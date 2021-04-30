using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WaProject_API.Migrations
{
    public partial class _2021_04_29_001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlacaDoVeiculo",
                table: "Equipe",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Descricao", "Nome", "PlacaDoVeiculo" },
                values: new object[] { "Equipe Cod - 8520 atendimento especial", "Equipe Setor - 44", "352-8071" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Descricao", "Nome", "PlacaDoVeiculo" },
                values: new object[] { "Equipe Cod - 5448 atendimento especial", "Equipe Setor - 48", "541-9281" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Descricao", "PlacaDoVeiculo" },
                values: new object[] { "Equipe Cod - 5529 atendimento especial", "969-7555" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Descricao", "Nome", "PlacaDoVeiculo" },
                values: new object[] { "Equipe Cod - 6169 atendimento especial", "Equipe Setor - 42", "659-4397" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Descricao", "Nome", "PlacaDoVeiculo" },
                values: new object[] { "Equipe Cod - 3889 atendimento especial", "Equipe Setor - 41", "242-6190" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Descricao", "Nome", "PlacaDoVeiculo" },
                values: new object[] { "Equipe Cod - 7219 atendimento especial", "Equipe Setor - 48", "488-2633" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Descricao", "Nome", "PlacaDoVeiculo" },
                values: new object[] { "Equipe Cod - 3898 atendimento especial", "Equipe Setor - 46", "992-4984" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Descricao", "Nome", "PlacaDoVeiculo" },
                values: new object[] { "Equipe Cod - 5852 atendimento especial", "Equipe Setor - 48", "750-6107" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Descricao", "Nome", "PlacaDoVeiculo" },
                values: new object[] { "Equipe Cod - 5135 atendimento especial", "Equipe Setor - 44", "259-4776" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Descricao", "Nome", "PlacaDoVeiculo" },
                values: new object[] { "Equipe Cod - 7901 atendimento especial", "Equipe Setor - 49", "595-8964" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 1, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(4193), new DateTime(2021, 4, 29, 15, 39, 28, 92, DateTimeKind.Local).AddTicks(384), "Rua 6, Numero 79, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 1, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6456), new DateTime(2021, 4, 30, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6418), "Rua 12, Numero 111, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 2, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6510), new DateTime(2021, 5, 1, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6507), "Rua 7, Numero 103, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6521), new DateTime(2021, 5, 2, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6519), "Rua 14, Numero 81, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 4, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6531), new DateTime(2021, 5, 3, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6529), "Rua 16, Numero 113, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 5, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6540), new DateTime(2021, 5, 4, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6537), "Rua 8, Numero 187, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 6, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6548), new DateTime(2021, 5, 5, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6547), "Rua 14, Numero 122, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 7, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6558), new DateTime(2021, 5, 6, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6556), "Rua 8, Numero 187, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 8, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6568), new DateTime(2021, 5, 7, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6565), "Rua 11, Numero 87, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 9, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6576), new DateTime(2021, 5, 8, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6574), "Rua 8, Numero 188, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 7597 Samsung", "Tv LED Cod - 48", 1912m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 5196 Samsung", "Tv LED Cod - 43", 1720m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 2914 Samsung", "Tv LED Cod - 46", 1863m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 7092 Samsung", "Tv LED Cod - 40", 1285m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 8277 Samsung", "Tv LED Cod - 40", 1065m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 5494 Samsung", "Tv LED Cod - 46", 1201m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 6134 Samsung", "Tv LED Cod - 40", 1499m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 2630 Samsung", "Tv LED Cod - 41", 1748m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 5171 Samsung", "Tv LED Cod - 47", 1289m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 4923 Samsung", "Tv LED Cod - 47", 1275m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 4445 Samsung", "Tv LED Cod - 43", 1718m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Descricao", "Valor" },
                values: new object[] { "Tv LED Cod - 6600 Samsung", 1058m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 2777 Samsung", "Tv LED Cod - 48", 1622m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Descricao", "Valor" },
                values: new object[] { "Tv LED Cod - 6155 Samsung", 1862m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 7214 Samsung", "Tv LED Cod - 45", 1822m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Descricao", "Valor" },
                values: new object[] { "Tv LED Cod - 4958 Samsung", 1508m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 5368 Samsung", "Tv LED Cod - 43", 1847m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 7230 Samsung", "Tv LED Cod - 47", 1960m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 7240 Samsung", "Tv LED Cod - 43", 1709m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlacaDoVeiculo",
                table: "Equipe");

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Descricao", "Nome" },
                values: new object[] { "Equipe Cod - 6801 atendimento especial", "Equipe Setor - 42" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Descricao", "Nome" },
                values: new object[] { "Equipe Cod - 7638 atendimento especial", "Equipe Setor - 47" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 3,
                column: "Descricao",
                value: "Equipe Cod - 5520 atendimento especial");

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Descricao", "Nome" },
                values: new object[] { "Equipe Cod - 3742 atendimento especial", "Equipe Setor - 45" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Descricao", "Nome" },
                values: new object[] { "Equipe Cod - 6294 atendimento especial", "Equipe Setor - 45" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Descricao", "Nome" },
                values: new object[] { "Equipe Cod - 4494 atendimento especial", "Equipe Setor - 41" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Descricao", "Nome" },
                values: new object[] { "Equipe Cod - 2867 atendimento especial", "Equipe Setor - 49" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Descricao", "Nome" },
                values: new object[] { "Equipe Cod - 4120 atendimento especial", "Equipe Setor - 43" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Descricao", "Nome" },
                values: new object[] { "Equipe Cod - 4101 atendimento especial", "Equipe Setor - 46" });

            migrationBuilder.UpdateData(
                table: "Equipe",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Descricao", "Nome" },
                values: new object[] { "Equipe Cod - 7993 atendimento especial", "Equipe Setor - 48" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 4, 30, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(1522), new DateTime(2021, 4, 28, 21, 53, 48, 623, DateTimeKind.Local).AddTicks(9), "Rua 2, Numero 133, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 4, 30, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4477), new DateTime(2021, 4, 29, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4429), "Rua 18, Numero 135, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 1, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4537), new DateTime(2021, 4, 30, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4534), "Rua 13, Numero 154, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 2, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4550), new DateTime(2021, 5, 1, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4548), "Rua 6, Numero 152, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 3, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4560), new DateTime(2021, 5, 2, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4558), "Rua 7, Numero 148, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 4, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4569), new DateTime(2021, 5, 3, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4567), "Rua 3, Numero 148, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 5, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(5001), new DateTime(2021, 5, 4, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(4994), "Rua 14, Numero 71, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 6, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(5013), new DateTime(2021, 5, 5, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(5011), "Rua 1, Numero 186, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 7, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(5022), new DateTime(2021, 5, 6, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(5021), "Rua 6, Numero 107, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DataDaEntregaRealizada", "DataDeCriacao", "EnderecoEntregaRealizada" },
                values: new object[] { new DateTime(2021, 5, 8, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(5031), new DateTime(2021, 5, 7, 21, 53, 48, 626, DateTimeKind.Local).AddTicks(5030), "Rua 3, Numero 160, Sao Paulo" });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 3279 Samsung", "Tv LED Cod - 47", 1345m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 8254 Samsung", "Tv LED Cod - 41", 1245m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 3978 Samsung", "Tv LED Cod - 49", 1376m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 2446 Samsung", "Tv LED Cod - 41", 1692m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 3195 Samsung", "Tv LED Cod - 48", 1239m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 7515 Samsung", "Tv LED Cod - 43", 1107m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 3089 Samsung", "Tv LED Cod - 43", 1120m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 3136 Samsung", "Tv LED Cod - 40", 1710m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 7509 Samsung", "Tv LED Cod - 45", 1744m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 7440 Samsung", "Tv LED Cod - 45", 1737m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 8847 Samsung", "Tv LED Cod - 42", 1573m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Descricao", "Valor" },
                values: new object[] { "Tv LED Cod - 2121 Samsung", 1045m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 6244 Samsung", "Tv LED Cod - 43", 1911m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Descricao", "Valor" },
                values: new object[] { "Tv LED Cod - 6153 Samsung", 1292m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 4785 Samsung", "Tv LED Cod - 48", 1549m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Descricao", "Valor" },
                values: new object[] { "Tv LED Cod - 5256 Samsung", 1741m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 8907 Samsung", "Tv LED Cod - 48", 1514m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 8583 Samsung", "Tv LED Cod - 45", 1651m });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Descricao", "Nome", "Valor" },
                values: new object[] { "Tv LED Cod - 6602 Samsung", "Tv LED Cod - 47", 1020m });
        }
    }
}
