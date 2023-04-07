using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Menager.Migrations
{
    public partial class AddAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Reservations_ReservationsId",
                table: "Clients");

            migrationBuilder.DropTable(
                name: "UserReservations");

            migrationBuilder.DropIndex(
                name: "IX_Clients_ReservationsId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ReservationsId",
                table: "Clients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservationsId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserReservations_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserReservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ReservationsId",
                table: "Clients",
                column: "ReservationsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReservations_ReservationId",
                table: "UserReservations",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReservations_UserId",
                table: "UserReservations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Reservations_ReservationsId",
                table: "Clients",
                column: "ReservationsId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
