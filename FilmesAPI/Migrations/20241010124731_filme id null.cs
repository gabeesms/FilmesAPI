using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmesAPI.Migrations
{
    /// <inheritdoc />
    public partial class filmeidnull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Filmes_FilmeId",
                table: "Sessoes");

            migrationBuilder.AlterColumn<int>(
                name: "FilmeId",
                table: "Sessoes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Filmes_FilmeId",
                table: "Sessoes",
                column: "FilmeId",
                principalTable: "Filmes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Filmes_FilmeId",
                table: "Sessoes");

            migrationBuilder.AlterColumn<int>(
                name: "FilmeId",
                table: "Sessoes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Filmes_FilmeId",
                table: "Sessoes",
                column: "FilmeId",
                principalTable: "Filmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
