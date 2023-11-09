using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Ca.Infrastructure.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "00000000-0000-0000-0000-000000000000", "admin@games.com", false, "Bart", "Soete", false, null, "ADMIN@GAMES.COM", "ADMIN@GAMES.COM", "AQAAAAEAACcQAAAAEPY03bxE9+6qsrRzYUfVSxqEEVpbJZaF/FidQZx+qwhhQ7m//0BBMkMceMfZ1bTWbw==", null, false, "00000000-0000-0000-0000-000000000000", false, "admin@games.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2", 0, "00000000-0000-0000-0000-000000000000", "user@games.com", false, "Mileto", "Di Marco", false, null, "USER@GAMES.COM", "USER@GAMES.COM", "AQAAAAEAACcQAAAAEAaNLqHd4Wsi6i8heEKr6ihT/7EWYS6K+dRFGh8hUUpGyi3rg2BQKK9RIGCJvrfKFQ==", null, false, "00000000-0000-0000-0000-000000000000", false, "user@games.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
