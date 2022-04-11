using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthencationWebapi.Migrations
{
    public partial class inittable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tblusers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fname = table.Column<string>(type: "Nvarchar(50)", nullable: false),
                    lname = table.Column<string>(type: "Nvarchar(50)", nullable: false),
                    email = table.Column<string>(type: "Nvarchar(255)", nullable: false),
                    password = table.Column<string>(type: "Nvarchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tblusers", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tblusers");
        }
    }
}
