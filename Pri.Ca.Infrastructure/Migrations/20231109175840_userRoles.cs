using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Ca.Infrastructure.Migrations
{
    public partial class userRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "17886775-76f7-4c34-84bd-6aa122343a69", "Admin", "ADMIN" },
                    { "2", "dee104b0-7836-4209-a1db-49fe9c258d50", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEK+cRat4FNzMU1gglv4mq8/bYAmmwdK9Wn9+0MSSUJo+msKnVR0my842x+zHgTVw+g==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENPoe17b/l3XR4UFGbOKy7kGA84FdY83u89Eem2WLwvFkbsMJmX52lrontM9CGO/Gg==");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPY03bxE9+6qsrRzYUfVSxqEEVpbJZaF/FidQZx+qwhhQ7m//0BBMkMceMfZ1bTWbw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAaNLqHd4Wsi6i8heEKr6ihT/7EWYS6K+dRFGh8hUUpGyi3rg2BQKK9RIGCJvrfKFQ==");
        }
    }
}
