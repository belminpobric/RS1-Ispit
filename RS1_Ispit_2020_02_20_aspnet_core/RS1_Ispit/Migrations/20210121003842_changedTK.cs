using Microsoft.EntityFrameworkCore.Migrations;

namespace RS1_Ispit_asp.net_core.Migrations
{
    public partial class changedTK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TakmicenjeUcesnici_Odjeljenje_OdjeljenjeID",
                table: "TakmicenjeUcesnici");

            migrationBuilder.RenameColumn(
                name: "OdjeljenjeID",
                table: "TakmicenjeUcesnici",
                newName: "OdjeljenjeStavkaID");

            migrationBuilder.RenameIndex(
                name: "IX_TakmicenjeUcesnici_OdjeljenjeID",
                table: "TakmicenjeUcesnici",
                newName: "IX_TakmicenjeUcesnici_OdjeljenjeStavkaID");

            migrationBuilder.AddForeignKey(
                name: "FK_TakmicenjeUcesnici_OdjeljenjeStavka_OdjeljenjeStavkaID",
                table: "TakmicenjeUcesnici",
                column: "OdjeljenjeStavkaID",
                principalTable: "OdjeljenjeStavka",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TakmicenjeUcesnici_OdjeljenjeStavka_OdjeljenjeStavkaID",
                table: "TakmicenjeUcesnici");

            migrationBuilder.RenameColumn(
                name: "OdjeljenjeStavkaID",
                table: "TakmicenjeUcesnici",
                newName: "OdjeljenjeID");

            migrationBuilder.RenameIndex(
                name: "IX_TakmicenjeUcesnici_OdjeljenjeStavkaID",
                table: "TakmicenjeUcesnici",
                newName: "IX_TakmicenjeUcesnici_OdjeljenjeID");

            migrationBuilder.AddForeignKey(
                name: "FK_TakmicenjeUcesnici_Odjeljenje_OdjeljenjeID",
                table: "TakmicenjeUcesnici",
                column: "OdjeljenjeID",
                principalTable: "Odjeljenje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
