using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginService.Migrations
{
    public partial class SeAgregaDbSetIdentityUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "identityUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "identityUserRoles");
        }
    }
}
