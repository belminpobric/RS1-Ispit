using Microsoft.EntityFrameworkCore.Migrations;

namespace RS1_2020_01_30.Migrations
{
    public partial class updatedTakmicenje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Takmicenje_Predmet_PredmetId",
                table: "Takmicenje");

            migrationBuilder.DropForeignKey(
                name: "FK_takmicenjeStavka_OdjeljenjeStavka_OdjeljenjeStavkaID",
                table: "takmicenjeStavka");

            migrationBuilder.DropForeignKey(
                name: "FK_takmicenjeStavka_Takmicenje_TakmicenjeID",
                table: "takmicenjeStavka");

            migrationBuilder.RenameColumn(
                name: "PredmetId",
                table: "Takmicenje",
                newName: "PredmetID");

            migrationBuilder.RenameIndex(
                name: "IX_Takmicenje_PredmetId",
                table: "Takmicenje",
                newName: "IX_Takmicenje_PredmetID");

            migrationBuilder.AlterColumn<int>(
                name: "PredmetID",
                table: "Takmicenje",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Takmicenje_Predmet_PredmetID",
                table: "Takmicenje",
                column: "PredmetID",
                principalTable: "Predmet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_takmicenjeStavka_OdjeljenjeStavka_OdjeljenjeStavkaID",
                table: "takmicenjeStavka",
                column: "OdjeljenjeStavkaID",
                principalTable: "OdjeljenjeStavka",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_takmicenjeStavka_Takmicenje_TakmicenjeID",
                table: "takmicenjeStavka",
                column: "TakmicenjeID",
                principalTable: "Takmicenje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Takmicenje_Predmet_PredmetID",
                table: "Takmicenje");

            migrationBuilder.DropForeignKey(
                name: "FK_takmicenjeStavka_OdjeljenjeStavka_OdjeljenjeStavkaID",
                table: "takmicenjeStavka");

            migrationBuilder.DropForeignKey(
                name: "FK_takmicenjeStavka_Takmicenje_TakmicenjeID",
                table: "takmicenjeStavka");

            migrationBuilder.RenameColumn(
                name: "PredmetID",
                table: "Takmicenje",
                newName: "PredmetId");

            migrationBuilder.RenameIndex(
                name: "IX_Takmicenje_PredmetID",
                table: "Takmicenje",
                newName: "IX_Takmicenje_PredmetId");

            migrationBuilder.AlterColumn<int>(
                name: "PredmetId",
                table: "Takmicenje",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Takmicenje_Predmet_PredmetId",
                table: "Takmicenje",
                column: "PredmetId",
                principalTable: "Predmet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_takmicenjeStavka_OdjeljenjeStavka_OdjeljenjeStavkaID",
                table: "takmicenjeStavka",
                column: "OdjeljenjeStavkaID",
                principalTable: "OdjeljenjeStavka",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_takmicenjeStavka_Takmicenje_TakmicenjeID",
                table: "takmicenjeStavka",
                column: "TakmicenjeID",
                principalTable: "Takmicenje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
