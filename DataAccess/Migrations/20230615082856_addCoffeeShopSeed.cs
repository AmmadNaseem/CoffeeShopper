using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class addCoffeeShopSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO CoffeeShops(Name,OpeningHours,Address)VALUES('pj coffe shop new orleans','9-5 mon-sat','9079 west locust')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
