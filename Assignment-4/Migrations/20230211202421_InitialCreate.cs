using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment2OnlineGroceryMembershipPrototypeCardinal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<int>(type: "INTEGER", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "drivers",
                columns: table => new
                {
                    DriversID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonsID = table.Column<int>(type: "INTEGER", nullable: false),
                    AddressID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drivers", x => x.DriversID);
                });

            migrationBuilder.CreateTable(
                name: "menuItems",
                columns: table => new
                {
                    MenuItemsID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RestaurantsID = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menuItems", x => x.MenuItemsID);
                });

            migrationBuilder.CreateTable(
                name: "menuOrders",
                columns: table => new
                {
                    MenuOrdersID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderID = table.Column<int>(type: "INTEGER", nullable: false),
                    MenuItemID = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Subtotal = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menuOrders", x => x.MenuOrdersID);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    OrdersID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RestaurantsID = table.Column<int>(type: "INTEGER", nullable: false),
                    ShopperID = table.Column<int>(type: "INTEGER", nullable: false),
                    DriverID = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CompletionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Total = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.OrdersID);
                });

            migrationBuilder.CreateTable(
                name: "persons",
                columns: table => new
                {
                    PersonsID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons", x => x.PersonsID);
                });

            migrationBuilder.CreateTable(
                name: "restaurants",
                columns: table => new
                {
                    RestaurantsID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AddressID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurants", x => x.RestaurantsID);
                });

            migrationBuilder.CreateTable(
                name: "shoppers",
                columns: table => new
                {
                    ShoppersID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonsID = table.Column<int>(type: "INTEGER", nullable: false),
                    AddressID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoppers", x => x.ShoppersID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "drivers");

            migrationBuilder.DropTable(
                name: "menuItems");

            migrationBuilder.DropTable(
                name: "menuOrders");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "persons");

            migrationBuilder.DropTable(
                name: "restaurants");

            migrationBuilder.DropTable(
                name: "shoppers");
        }
    }
}
