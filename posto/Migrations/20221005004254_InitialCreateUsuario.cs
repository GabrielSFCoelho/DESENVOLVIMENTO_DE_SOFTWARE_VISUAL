using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace posto.Migrations
{
    public partial class InitialCreateUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "Usuarios",
                newName: "cpf");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Usuarios",
                newName: "email");
        }
    }
}
