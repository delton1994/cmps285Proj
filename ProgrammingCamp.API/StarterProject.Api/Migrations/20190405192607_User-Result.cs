using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class UserResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserResult",
                newName: "ResultId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 102, 141, 234, 12, 180, 61, 19, 227, 149, 178, 44, 128, 92, 213, 70, 30, 200, 206, 69, 121 }, new byte[] { 21, 224, 38, 136, 239, 168, 87, 150, 0, 7, 228, 81, 34, 95, 70, 205 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 232, 191, 81, 158, 123, 1, 158, 243, 44, 58, 43, 241, 137, 219, 30, 215, 201, 137, 36, 58 }, new byte[] { 227, 56, 100, 160, 114, 213, 130, 75, 93, 40, 199, 43, 246, 144, 66, 193 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResultId",
                table: "UserResult",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 60, 240, 56, 204, 151, 181, 120, 185, 163, 136, 208, 78, 201, 244, 129, 15, 178, 218, 124, 64 }, new byte[] { 46, 241, 101, 177, 90, 104, 57, 67, 33, 143, 128, 166, 240, 165, 144, 105 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 179, 101, 111, 148, 53, 186, 72, 190, 230, 19, 151, 29, 77, 70, 213, 94, 77, 25, 0, 40 }, new byte[] { 193, 0, 3, 207, 41, 7, 6, 199, 254, 225, 106, 117, 5, 161, 236, 200 } });
        }
    }
}
