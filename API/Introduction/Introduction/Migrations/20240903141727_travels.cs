using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Introduction.Migrations
{
    /// <inheritdoc />
    public partial class travels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "people");

            migrationBuilder.AddPrimaryKey(
                name: "PK_people",
                table: "people",
                column: "person_id");

            migrationBuilder.CreateTable(
                name: "travel",
                columns: table => new
                {
                    travel_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    travel_start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    travel_end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    travel_start_city_id = table.Column<int>(type: "int", nullable: false),
                    travel_end_city_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_travel", x => x.travel_id);
                    table.ForeignKey(
                        name: "FK_travel_city_travel_end_city_id",
                        column: x => x.travel_end_city_id,
                        principalTable: "city",
                        principalColumn: "city_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_travel_city_travel_start_city_id",
                        column: x => x.travel_start_city_id,
                        principalTable: "city",
                        principalColumn: "city_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_travel_travel_end_city_id",
                table: "travel",
                column: "travel_end_city_id");

            migrationBuilder.CreateIndex(
                name: "IX_travel_travel_start_city_id",
                table: "travel",
                column: "travel_start_city_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "travel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_people",
                table: "people");

            migrationBuilder.RenameTable(
                name: "people",
                newName: "Person");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "person_id");
        }
    }
}
