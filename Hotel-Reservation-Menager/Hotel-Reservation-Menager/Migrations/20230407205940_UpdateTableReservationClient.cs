using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Menager.Migrations
{
    public partial class UpdateTableReservationClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Clients_ClientsId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationClient_Clients_ClientId",
                table: "ReservationClient");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationClient_Reservations_ReservationId",
                table: "ReservationClient");

            migrationBuilder.DropIndex(
                name: "IX_ReservationClient_ClientId",
                table: "ReservationClient");

            migrationBuilder.DropIndex(
                name: "IX_ReservationClient_ReservationId",
                table: "ReservationClient");

            migrationBuilder.DropIndex(
                name: "IX_Clients_ClientsId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ClientsId",
                table: "Clients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientsId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReservationClient_ClientId",
                table: "ReservationClient",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationClient_ReservationId",
                table: "ReservationClient",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ClientsId",
                table: "Clients",
                column: "ClientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Clients_ClientsId",
                table: "Clients",
                column: "ClientsId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationClient_Clients_ClientId",
                table: "ReservationClient",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationClient_Reservations_ReservationId",
                table: "ReservationClient",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
