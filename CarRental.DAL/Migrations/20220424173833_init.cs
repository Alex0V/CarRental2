using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Car_Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClientSurename = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClientMiddlename = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fuel_Type = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GearboxTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gearbox_Type = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearboxTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    СityID = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationDetails_Cities_СityID",
                        column: x => x.СityID,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LicensePlates = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Pledge = table.Column<int>(type: "int", nullable: false),
                    PassengerSeats = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    TrunkVolume = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    FuelConsumption = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NumberOfDoors = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    GearboxTypeID = table.Column<int>(type: "int", nullable: false),
                    EngineCapacity = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    FuelTypeID = table.Column<int>(type: "int", nullable: false),
                    CarTypeID = table.Column<int>(type: "int", nullable: false),
                    FotoName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarTypes_CarTypeID",
                        column: x => x.CarTypeID,
                        principalTable: "CarTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_FuelTypes_FuelTypeID",
                        column: x => x.FuelTypeID,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_GearboxTypes_GearboxTypeID",
                        column: x => x.GearboxTypeID,
                        principalTable: "GearboxTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_LocationDetails_LocationID",
                        column: x => x.LocationID,
                        principalTable: "LocationDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinalPrice = table.Column<int>(type: "int", nullable: false),
                    PlaceOfReceiptID = table.Column<int>(type: "int", nullable: false),
                    PlaceOfReturnID = table.Column<int>(type: "int", nullable: false),
                    DateTimeOfReceipt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeOfReturn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_LocationDetails_PlaceOfReceiptID",
                        column: x => x.PlaceOfReceiptID,
                        principalTable: "LocationDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_LocationDetails_PlaceOfReturnID",
                        column: x => x.PlaceOfReturnID,
                        principalTable: "LocationDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TextReviews = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarTypes",
                columns: new[] { "Id", "Car_Type" },
                values: new object[,]
                {
                    { 1, "Купе" },
                    { 2, "Кросовер" },
                    { 3, "Універсал" },
                    { 4, "Бюджет" },
                    { 5, "Бізнес" },
                    { 6, "Комфорт" },
                    { 7, "Преміум" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName" },
                values: new object[,]
                {
                    { 1, "Київ" },
                    { 2, "Львів" },
                    { 3, "Одеса" },
                    { 4, "Чернівці" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "ClientMiddlename", "ClientName", "ClientSurename", "DateOfBirth", "Email", "Gender", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Володимирович", "Олександр", "Дзюба", new DateTime(2000, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "client1@gmail.com", "Чоловік", "+380 500 111 111" },
                    { 2, "Миколайович", "Денис", "Миронець", new DateTime(2000, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "client2@gmail.com", "Чоловік", "+380 500 222 222" },
                    { 3, "Кирилович", "Сергій", "Гладик", new DateTime(1987, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "client3@gmail.com", "Чоловік", "+380 500 333 333" },
                    { 4, "Ігорівна", "Ірина", "Палій", new DateTime(1990, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "client4@gmail.com", "Жінка", "+380 500 444 444" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Fuel_Type" },
                values: new object[,]
                {
                    { 1, "Бензин" },
                    { 2, "Дизель" },
                    { 3, "Електрика" }
                });

            migrationBuilder.InsertData(
                table: "GearboxTypes",
                columns: new[] { "Id", "Gearbox_Type" },
                values: new object[,]
                {
                    { 1, "Автомат" },
                    { 2, "Механіка" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarName", "CarTypeID", "EngineCapacity", "FotoName", "FuelConsumption", "FuelTypeID", "GearboxTypeID", "LicensePlates", "NumberOfDoors", "PassengerSeats", "Pledge", "Price", "TrunkVolume" },
                values: new object[,]
                {
                    { 1, "VW POLO SEDAN", 4, "1.4", "VW POLO SEDAN.jpg", "6-8", 1, 1, "АВ 4324 BB", "4", "5", 13500, 1200, "460" },
                    { 2, "FORD FIESTA", 4, "1.6", "FORD FIESTA.jpg", "6-7", 1, 1, "AB 3354 BB", "5", "5", 13100, 1100, "292" },
                    { 3, "NISSAN JUKE", 2, "1.6", "NISSAN JUKE.jpg", "6-8", 1, 1, "AB 6544 EC", "5", "5", 17500, 1400, "520" },
                    { 4, "KIA-SPORTAGE", 2, "1.6", "KIA-SPORTAGE.jpg", "6-9", 1, 1, "AA 8472 CE", "5", "5", 23500, 200, "580" },
                    { 5, "SKODA OCTAVIA A8", 6, "1.6", "SKODA OCTAVIA A8.jpg", "5-7", 1, 1, "AA 1432 BC", "4", "5", 21000, 1500, "500" },
                    { 6, "TOYOTA COROLLA", 6, "1.6", "TOYOTA COROLLA.jpg", "6-8", 1, 1, "AA 2431 CB", "4", "5", 19000, 1400, "480" },
                    { 7, "VW TOUAREG", 7, "1.6", "VW TOUAREG.jpg", "7.6", 2, 1, "AA 1212 CB", "5", "5", 64700, 5200, "590" },
                    { 8, "BMW X5 M PAKET", 7, "3.0", "BMW X5 M PAKET.jpg", "7.1", 2, 1, "AA 2234 CB", "5", "5", 99000, 10000, "600" },
                    { 9, "FORD MONDEO", 5, "2.0", "FORD MONDEO.jpg", "9-10", 1, 1, "СA 4532 CB", "4", "5", 30000, 2000, "500" },
                    { 10, "AUDI A6 S-LINE", 5, "2.0", "AUDI A6 S-LINE.jpg", "9-10", 1, 1, "AС 2443 CB", "4", "5", 410000, 4500, "565" }
                });

            migrationBuilder.InsertData(
                table: "LocationDetails",
                columns: new[] { "Id", "HouseNumber", "Street", "СityID" },
                values: new object[,]
                {
                    { 1, "21", "Глибочицька", 1 },
                    { 2, "8", "Лічаківська", 2 },
                    { 3, "43", "Осипова", 3 },
                    { 4, "35", "Героїв Майдану", 4 }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CarID", "ClientID", "DateTimeOfReceipt", "DateTimeOfReturn", "FinalPrice", "PlaceOfReceiptID", "PlaceOfReturnID" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2021, 6, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), 25000, 1, 1 },
                    { 2, 2, 2, new DateTime(2021, 9, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 45000, 2, 2 },
                    { 3, 3, 4, new DateTime(2021, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), 35000, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "LocationID", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "rentuacarKiev@gmail.com", 1, "+380 503 456 789" },
                    { 2, "rentuacarLviv@gmail.com", 2, "+380 504 456 456" },
                    { 3, "rentuacarOdessa@gmail.com", 3, "+380 505 567 567" },
                    { 4, "rentuacarChernivtsi@gmail.com", 4, "+380 507 456 321" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CarID", "ClientID", "Rating", "TextReviews" },
                values: new object[,]
                {
                    { 1, 1, 4, "5", "Все на вищому рівні." },
                    { 2, 2, 3, "5", "Все на вищому рівні." },
                    { 3, 3, 3, "5", "Все на вищому рівні." },
                    { 4, 4, 2, "5", "Все на вищому рівні." },
                    { 5, 5, 1, "5", "Все на вищому рівні." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CarID",
                table: "Bookings",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ClientID",
                table: "Bookings",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PlaceOfReceiptID",
                table: "Bookings",
                column: "PlaceOfReceiptID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PlaceOfReturnID",
                table: "Bookings",
                column: "PlaceOfReturnID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarTypeID",
                table: "Cars",
                column: "CarTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelTypeID",
                table: "Cars",
                column: "FuelTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_GearboxTypeID",
                table: "Cars",
                column: "GearboxTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_LocationID",
                table: "Contacts",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDetails_СityID",
                table: "LocationDetails",
                column: "СityID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CarID",
                table: "Reviews",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ClientID",
                table: "Reviews",
                column: "ClientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "LocationDetails");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "CarTypes");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "GearboxTypes");
        }
    }
}
