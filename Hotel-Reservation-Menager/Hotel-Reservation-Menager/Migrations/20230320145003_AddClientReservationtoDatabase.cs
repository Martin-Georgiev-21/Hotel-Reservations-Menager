using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Menager.Migrations
{
    public partial class AddUserReservationtoDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Reservations_ReservationsId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "ReservationsId",
                table: "Clients",
                newName: "ClientsId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_ReservationsId",
                table: "Clients",
                newName: "IX_Clients_ClientsId");

            migrationBuilder.AlterColumn<string>(
                name: "Accommodation",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "ReservationClient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationClient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationClient_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationClient_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationClient_ClientId",
                table: "ReservationClient",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationClient_ReservationId",
                table: "ReservationClient",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Clients_ClientsId",
                table: "Clients",
                column: "ClientsId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Clients_ClientsId",
                table: "Clients");

            migrationBuilder.DropTable(
                name: "ReservationClient");

            migrationBuilder.RenameColumn(
                name: "ClientsId",
                table: "Clients",
                newName: "ReservationsId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_ClientsId",
                table: "Clients",
                newName: "IX_Clients_ReservationsId");

            migrationBuilder.AlterColumn<string>(
                name: "Accommodation",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
