using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectPractikum.Context.Migrations
{
    public partial class tow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_children_people_ParentPersonId",
                table: "children");

            migrationBuilder.DropIndex(
                name: "IX_children_ParentPersonId",
                table: "children");

            migrationBuilder.DropColumn(
                name: "ParentPersonId",
                table: "children");

            migrationBuilder.AddColumn<string>(
                name: "ParentID",
                table: "children",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentID",
                table: "children");

            migrationBuilder.AddColumn<string>(
                name: "ParentPersonId",
                table: "children",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_children_ParentPersonId",
                table: "children",
                column: "ParentPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_children_people_ParentPersonId",
                table: "children",
                column: "ParentPersonId",
                principalTable: "people",
                principalColumn: "PersonId");
        }
    }
}
