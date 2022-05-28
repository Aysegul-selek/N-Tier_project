using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarkaID",
                table: "Uruns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MusteriID",
                table: "Uruns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_MarkaID",
                table: "Uruns",
                column: "MarkaID");

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_MusteriID",
                table: "Uruns",
                column: "MusteriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Uruns_MArkas_MarkaID",
                table: "Uruns",
                column: "MarkaID",
                principalTable: "MArkas",
                principalColumn: "MarkaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Uruns_Musteris_MusteriID",
                table: "Uruns",
                column: "MusteriID",
                principalTable: "Musteris",
                principalColumn: "MusteriID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uruns_MArkas_MarkaID",
                table: "Uruns");

            migrationBuilder.DropForeignKey(
                name: "FK_Uruns_Musteris_MusteriID",
                table: "Uruns");

            migrationBuilder.DropIndex(
                name: "IX_Uruns_MarkaID",
                table: "Uruns");

            migrationBuilder.DropIndex(
                name: "IX_Uruns_MusteriID",
                table: "Uruns");

            migrationBuilder.DropColumn(
                name: "MarkaID",
                table: "Uruns");

            migrationBuilder.DropColumn(
                name: "MusteriID",
                table: "Uruns");
        }
    }
}
