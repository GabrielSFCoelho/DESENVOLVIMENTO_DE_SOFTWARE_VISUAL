using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace posto.Migrations
{
    public partial class InitialCreateLocacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_locacao_locacaoJogos_idLocacaoJogo",
                table: "locacao");

            migrationBuilder.DropIndex(
                name: "IX_locacao_idLocacaoJogo",
                table: "locacao");

            migrationBuilder.DropColumn(
                name: "idLocacaoJogo",
                table: "locacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idLocacaoJogo",
                table: "locacao",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_locacao_idLocacaoJogo",
                table: "locacao",
                column: "idLocacaoJogo");

            migrationBuilder.AddForeignKey(
                name: "FK_locacao_locacaoJogos_idLocacaoJogo",
                table: "locacao",
                column: "idLocacaoJogo",
                principalTable: "locacaoJogos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
