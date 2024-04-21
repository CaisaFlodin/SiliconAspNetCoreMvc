using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Subscriber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckboxDaily = table.Column<bool>(type: "bit", nullable: false),
                    CheckboxEvent = table.Column<bool>(type: "bit", nullable: false),
                    CheckboxAdvertising = table.Column<bool>(type: "bit", nullable: false),
                    CheckboxStartups = table.Column<bool>(type: "bit", nullable: false),
                    CheckboxWeek = table.Column<bool>(type: "bit", nullable: false),
                    CheckboxPodcasts = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscribers");
        }
    }
}
