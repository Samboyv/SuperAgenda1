using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperAgenda1.Migrations
{
    public partial class add_tipo_contacto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoContacto",
                table: "Contactos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoContacto",
                table: "Contactos");
        }
    }
}
