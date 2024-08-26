using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Introduction.Migrations
{
    /// <inheritdoc />
    public partial class countryfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_continent_ContinentId",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "country",
                newName: "country_name");

            migrationBuilder.RenameColumn(
                name: "ContinentId",
                table: "country",
                newName: "continent_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "country",
                newName: "country_id");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_ContinentId",
                table: "country",
                newName: "IX_country_continent_id");

            migrationBuilder.AddColumn<string>(
                name: "country_code",
                table: "country",
                type: "char(2)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_country",
                table: "country",
                column: "country_id");

            migrationBuilder.AddForeignKey(
                name: "FK_country_continent_continent_id",
                table: "country",
                column: "continent_id",
                principalTable: "continent",
                principalColumn: "continent_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_country_continent_continent_id",
                table: "country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_country",
                table: "country");

            migrationBuilder.DropColumn(
                name: "country_code",
                table: "country");

            migrationBuilder.RenameTable(
                name: "country",
                newName: "Countries");

            migrationBuilder.RenameColumn(
                name: "country_name",
                table: "Countries",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "continent_id",
                table: "Countries",
                newName: "ContinentId");

            migrationBuilder.RenameColumn(
                name: "country_id",
                table: "Countries",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_country_continent_id",
                table: "Countries",
                newName: "IX_Countries_ContinentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_continent_ContinentId",
                table: "Countries",
                column: "ContinentId",
                principalTable: "continent",
                principalColumn: "continent_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
