using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectPractikum.Context.Migrations
{
    public partial class createDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "people",
                columns: table => new
                {
                    PersonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HMO = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_people", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "children",
                columns: table => new
                {
                    ChildId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParentPersonId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_children", x => x.ChildId);
                    table.ForeignKey(
                        name: "FK_children_people_ParentPersonId",
                        column: x => x.ParentPersonId,
                        principalTable: "people",
                        principalColumn: "PersonId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_children_ParentPersonId",
                table: "children",
                column: "ParentPersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "children");

            migrationBuilder.DropTable(
                name: "people");
        }
    }
}
