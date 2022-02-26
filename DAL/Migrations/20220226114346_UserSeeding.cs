using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UserSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserModels",
                columns: new[] { "Id", "EmailAdress", "GivenName", "Password", "Role", "Surname", "UserName" },
                values: new object[] { 1, "bsozer@gmail.com", "Burhan", "123456", "Administration", "Sozer", "burhan_admin" });

            migrationBuilder.InsertData(
                table: "UserModels",
                columns: new[] { "Id", "EmailAdress", "GivenName", "Password", "Role", "Surname", "UserName" },
                values: new object[] { 2, "bxxxx@gmail.com", "Orhan", "123456", "Seller", "Atmaca", "orhan_seller" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserModels",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
