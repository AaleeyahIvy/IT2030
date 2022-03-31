using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectTrips.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Accommodations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccommodationPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccommodationEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDo3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripId);
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AccommodationEmail", "AccommodationPhone", "Accommodations", "Destination", "End", "Start", "ToDo1", "ToDo2", "ToDo3" },
                values: new object[] { 1, "None", "None", "Botanical Garden w/ Fiance", "Ohio", new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Relax", null, null });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AccommodationEmail", "AccommodationPhone", "Accommodations", "Destination", "End", "Start", "ToDo1", "ToDo2", "ToDo3" },
                values: new object[] { 2, "None", "None", "RoadTrip", "Texarkana, AK", new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Relax", null, null });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AccommodationEmail", "AccommodationPhone", "Accommodations", "Destination", "End", "Start", "ToDo1", "ToDo2", "ToDo3" },
                values: new object[] { 3, "kiyoshisuites@net.com", "111-1111-1111", "Kiyoshi Hotel & Luxury Suites", "Japan", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Relax", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
