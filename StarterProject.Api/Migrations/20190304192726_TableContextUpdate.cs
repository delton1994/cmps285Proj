using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class TableContextUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Choices",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsAnswer",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 244, 119, 174, 128, 112, 142, 6, 58, 16, 160, 39, 83, 128, 33, 230, 171, 41, 157, 153, 231 }, new byte[] { 251, 145, 107, 85, 2, 181, 78, 21, 227, 253, 236, 87, 165, 19, 37, 248 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 114, 232, 116, 101, 24, 130, 22, 52, 240, 146, 216, 27, 56, 120, 71, 237, 106, 156, 122, 209 }, new byte[] { 178, 28, 235, 255, 173, 208, 217, 91, 63, 80, 195, 51, 243, 202, 241, 171 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Choices",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsAnswer",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 249, 192, 162, 124, 237, 94, 14, 179, 204, 169, 192, 83, 119, 250, 121, 210, 153, 168, 122, 174 }, new byte[] { 100, 253, 93, 129, 69, 93, 193, 169, 192, 8, 140, 99, 35, 144, 218, 18 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 56, 14, 106, 216, 209, 123, 25, 146, 144, 8, 167, 5, 8, 145, 168, 69, 208, 185, 169, 251 }, new byte[] { 193, 1, 4, 139, 187, 67, 74, 48, 28, 27, 128, 65, 207, 87, 48, 157 } });
        }
    }
}
