using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Phone_Book.Migrations
{
    public partial class ParentIDAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Person");
        }
    }
}
