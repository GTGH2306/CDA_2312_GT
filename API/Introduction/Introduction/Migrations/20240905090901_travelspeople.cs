using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Introduction.Migrations
{
    /// <inheritdoc />
    public partial class travelspeople : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "travel_end_date",
                table: "travel",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "travels_people",
                columns: table => new
                {
                    travel_id = table.Column<int>(type: "int", nullable: false),
                    person_id = table.Column<int>(type: "int", nullable: false),
                    driver = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_travels_people", x => new { x.travel_id, x.person_id });
                    table.ForeignKey(
                        name: "FK_travels_people_people_person_id",
                        column: x => x.person_id,
                        principalTable: "people",
                        principalColumn: "person_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_travels_people_travel_travel_id",
                        column: x => x.travel_id,
                        principalTable: "travel",
                        principalColumn: "travel_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_travels_people_person_id",
                table: "travels_people",
                column: "person_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "travels_people");

            migrationBuilder.AlterColumn<DateTime>(
                name: "travel_end_date",
                table: "travel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
