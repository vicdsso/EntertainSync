using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntertainSync.Migrations
{
    public partial class AdicionarLinkImagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
    name: "LinkImagem",
    table: "Adicionar",
    type: "nvarchar(max)",
    nullable: false,
    defaultValue: "");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
