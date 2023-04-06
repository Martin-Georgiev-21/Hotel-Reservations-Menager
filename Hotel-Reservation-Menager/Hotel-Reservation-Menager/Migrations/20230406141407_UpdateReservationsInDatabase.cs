using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Menager.Migrations
{
    public partial class UpdateReservationsInDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservationsId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ReservationsId",
                table: "Clients",
                column: "ReservationsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Reservations_ReservationsId",
                table: "Clients",
                column: "ReservationsId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Reservations_ReservationsId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_ReservationsId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ReservationsId",
                table: "Clients");
        }
    }
}
