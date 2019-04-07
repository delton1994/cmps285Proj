using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class AddinguserResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserResults_Users_UserId",
                table: "UserResults");

            migrationBuilder.DropIndex(
                name: "IX_UserResults_UserId",
                table: "UserResults");

            migrationBuilder.AddColumn<int>(
                name: "AnswerCorrect",
                table: "UserResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AnswersIncorrect",
                table: "UserResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "UserResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 199, 237, 223, 213, 226, 166, 84, 181, 69, 203, 187, 207, 54, 107, 231, 202, 158, 250, 76, 177 }, new byte[] { 223, 10, 146, 81, 22, 148, 125, 21, 39, 150, 65, 210, 139, 239, 243, 111 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 178, 149, 184, 187, 93, 102, 29, 38, 253, 238, 114, 186, 188, 52, 18, 123, 47, 198, 219, 190 }, new byte[] { 178, 12, 93, 196, 45, 138, 198, 131, 154, 13, 168, 129, 40, 231, 198, 95 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerCorrect",
                table: "UserResults");

            migrationBuilder.DropColumn(
                name: "AnswersIncorrect",
                table: "UserResults");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "UserResults");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 79, 222, 177, 170, 138, 247, 109, 192, 115, 134, 146, 149, 117, 54, 185, 68, 139, 27, 157, 212 }, new byte[] { 229, 56, 244, 109, 28, 23, 144, 179, 118, 241, 95, 243, 124, 26, 96, 68 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 22, 98, 14, 24, 53, 192, 174, 166, 26, 49, 74, 247, 96, 198, 183, 94, 146, 4, 245, 51 }, new byte[] { 244, 66, 48, 219, 228, 56, 81, 57, 5, 255, 76, 222, 15, 0, 47, 50 } });

            migrationBuilder.CreateIndex(
                name: "IX_UserResults_UserId",
                table: "UserResults",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserResults_Users_UserId",
                table: "UserResults",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
