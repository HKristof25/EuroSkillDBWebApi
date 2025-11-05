using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SzakmakApi.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_776 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orszagok",
                columns: table => new
                {
                    id = table.Column<string>(type: "TEXT", nullable: false),
                    orszagNev = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orszagok", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "szakmak",
                columns: table => new
                {
                    id = table.Column<string>(type: "TEXT", nullable: false),
                    szakmaNev = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_szakmak", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "versenyzok",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nev = table.Column<string>(type: "TEXT", nullable: false),
                    szakmaId = table.Column<string>(type: "TEXT", nullable: false),
                    orszagId = table.Column<string>(type: "TEXT", nullable: false),
                    pont = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_versenyzok", x => x.id);
                    table.ForeignKey(
                        name: "FK_versenyzok_orszagok_orszagId",
                        column: x => x.orszagId,
                        principalTable: "orszagok",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_versenyzok_szakmak_szakmaId",
                        column: x => x.szakmaId,
                        principalTable: "szakmak",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_versenyzok_orszagId",
                table: "versenyzok",
                column: "orszagId");

            migrationBuilder.CreateIndex(
                name: "IX_versenyzok_szakmaId",
                table: "versenyzok",
                column: "szakmaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "versenyzok");

            migrationBuilder.DropTable(
                name: "orszagok");

            migrationBuilder.DropTable(
                name: "szakmak");
        }
    }
}
