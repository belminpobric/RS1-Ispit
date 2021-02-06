using Microsoft.EntityFrameworkCore.Migrations;

namespace RS1_2020_07_06.Migrations
{
    public partial class addedRazred : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TakmicenjeUcesnik_Takmicenje_TakmicenjeID",
                table: "TakmicenjeUcesnik");

            migrationBuilder.AddColumn<int>(
                name: "Razred",
                table: "Takmicenje",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_TakmicenjeUcesnik_Takmicenje_TakmicenjeID",
                table: "TakmicenjeUcesnik",
                column: "TakmicenjeID",
                principalTable: "Takmicenje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TakmicenjeUcesnik_Takmicenje_TakmicenjeID",
                table: "TakmicenjeUcesnik");

            migrationBuilder.DropColumn(
                name: "Razred",
                table: "Takmicenje");

            migrationBuilder.AddForeignKey(
                name: "FK_TakmicenjeUcesnik_Takmicenje_TakmicenjeID",
                table: "TakmicenjeUcesnik",
                column: "TakmicenjeID",
                principalTable: "Takmicenje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
