using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Introduction.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "continent",
                columns: table => new
                {
                    continent_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    continent_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    continent_area = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_continent", x => x.continent_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "continent");
        }
    }
}
