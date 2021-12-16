using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Phone_Book.Migrations
{
    public partial class PersonListAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_PersonId",
                table: "Person",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Person_PersonId",
                table: "Person",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Person_PersonId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_PersonId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Person");
        }
    }
}
