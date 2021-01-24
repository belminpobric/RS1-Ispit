using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RS1_Ispit_asp.net_core.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Takmicenja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SkolaID = table.Column<int>(nullable: false),
                    PredmetID = table.Column<int>(nullable: false),
                    IsZakljucano = table.Column<bool>(nullable: false),
                    Razred = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takmicenja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Takmicenja_Predmet_PredmetID",
                        column: x => x.PredmetID,
                        principalTable: "Predmet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Takmicenja_Skola_SkolaID",
                        column: x => x.SkolaID,
                        principalTable: "Skola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TakmicenjeUcesnici",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OdjeljenjeID = table.Column<int>(nullable: false),
                    IsPristupio = table.Column<bool>(nullable: false),
                    Bodovi = table.Column<int>(nullable: false),
                    TakmicenjeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakmicenjeUcesnici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TakmicenjeUcesnici_Odjeljenje_OdjeljenjeID",
                        column: x => x.OdjeljenjeID,
                        principalTable: "Odjeljenje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TakmicenjeUcesnici_Takmicenja_TakmicenjeID",
                        column: x => x.TakmicenjeID,
                        principalTable: "Takmicenja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Takmicenja_PredmetID",
                table: "Takmicenja",
                column: "PredmetID");

            migrationBuilder.CreateIndex(
                name: "IX_Takmicenja_SkolaID",
                table: "Takmicenja",
                column: "SkolaID");

            migrationBuilder.CreateIndex(
                name: "IX_TakmicenjeUcesnici_OdjeljenjeID",
                table: "TakmicenjeUcesnici",
                column: "OdjeljenjeID");

            migrationBuilder.CreateIndex(
                name: "IX_TakmicenjeUcesnici_TakmicenjeID",
                table: "TakmicenjeUcesnici",
                column: "TakmicenjeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TakmicenjeUcesnici");

            migrationBuilder.DropTable(
                name: "Takmicenja");
        }
    }
}
