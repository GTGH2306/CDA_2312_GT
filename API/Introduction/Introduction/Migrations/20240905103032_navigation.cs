using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Introduction.Migrations
{
    /// <inheritdoc />
    public partial class navigation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_travel_city_travel_end_city_id",
                table: "travel");

            migrationBuilder.DropForeignKey(
                name: "FK_travel_city_travel_start_city_id",
                table: "travel");

            migrationBuilder.AddForeignKey(
                name: "FK_travel_city_travel_end_city_id",
                table: "travel",
                column: "travel_end_city_id",
                principalTable: "city",
                principalColumn: "city_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_travel_city_travel_start_city_id",
                table: "travel",
                column: "travel_start_city_id",
                principalTable: "city",
                principalColumn: "city_id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_travel_city_travel_end_city_id",
                table: "travel");

            migrationBuilder.DropForeignKey(
                name: "FK_travel_city_travel_start_city_id",
                table: "travel");

            migrationBuilder.AddForeignKey(
                name: "FK_travel_city_travel_end_city_id",
                table: "travel",
                column: "travel_end_city_id",
                principalTable: "city",
                principalColumn: "city_id");

            migrationBuilder.AddForeignKey(
                name: "FK_travel_city_travel_start_city_id",
                table: "travel",
                column: "travel_start_city_id",
                principalTable: "city",
                principalColumn: "city_id");
        }
    }
}
