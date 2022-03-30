using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace weekfoodgen.Data.Migrations
{
    public partial class listat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ViikkoLista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Viikko = table.Column<int>(type: "int", nullable: false),
                    Vuosi = table.Column<int>(type: "int", nullable: false),
                    Omistaja = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViikkoLista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ruoka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Omistaja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViikkoListaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruoka", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ruoka_ViikkoLista_ViikkoListaId",
                        column: x => x.ViikkoListaId,
                        principalTable: "ViikkoLista",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RaakaAine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RuokaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaakaAine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaakaAine_Ruoka_RuokaId",
                        column: x => x.RuokaId,
                        principalTable: "Ruoka",
                        principalColumn: "Id");
                });


            migrationBuilder.CreateIndex(
                name: "IX_RaakaAine_RuokaId",
                table: "RaakaAine",
                column: "RuokaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ruoka_ViikkoListaId",
                table: "Ruoka",
                column: "ViikkoListaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RaakaAine");

            migrationBuilder.DropTable(
                name: "Ruoka");

            migrationBuilder.DropTable(
                name: "ViikkoLista");

            migrationBuilder.DropIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants");
        }
    }
}
